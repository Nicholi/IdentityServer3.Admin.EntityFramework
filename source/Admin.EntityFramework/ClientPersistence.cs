using System;
using System.Linq;
using IdentityServer3.Admin.EntityFramework.Extensions;
using RefactorThis.GraphDiff;
using Thinktecture.IdentityServer.EntityFramework;
using IdentityServer3.Admin.Persistence;
using IdentityServer3.Admin.Persistence.Models;
using IdentityServer3.Admin.Persistence.Models.Storage;

namespace IdentityServer3.Admin.EntityFramework
{
    public class ClientPersistence : IPersistence<Client>
    {
        private readonly string _connectionString;

        public ClientPersistence(string connectionString)
        {
            _connectionString = connectionString;
        }

        public PageResult<Client> List(PagingInformation pagingInformation)
        {
            using (var context = new ClientConfigurationDbContext(_connectionString))
            {
                var clientQuery = (IQueryable<Thinktecture.IdentityServer.EntityFramework.Entities.Client>) context.Clients
                    .AsNoTracking();

                if (!String.IsNullOrEmpty(pagingInformation.SearchTerm))
                {
                    clientQuery = clientQuery.Where(s => s.ClientName.Contains(pagingInformation.SearchTerm));
                }

                clientQuery = clientQuery.OrderBy(pagingInformation.SortColumns);

                var result = new PageResult<Client>()
                {
                    Items = clientQuery.ApplySkipTake(pagingInformation).ToList().Select(i => i.ToModel()).ToList(),
                    TotalCount = clientQuery.Count(),
                };

                return result;
            }
        }

        public Client Get(int key)
        {
            using (var context = new ClientConfigurationDbContext(_connectionString))
            {
                var client = context.Clients.FirstOrDefault(i => i.Id == key);

                return client.ToModel();
            }
        }

        public void Delete(int key)
        {
            using (var context = new ClientConfigurationDbContext(_connectionString))
            {
                var entity = new Thinktecture.IdentityServer.EntityFramework.Entities.Client()
                {
                    Id = key
                };

                context.Clients.Attach(entity);
                context.Clients.Remove(entity);

                context.SaveChanges();
            }
        }

        public object Add(Client entity)
        {
            using (var context = new ClientConfigurationDbContext(_connectionString))
            {
                var client = entity.ToEntity();
                context.Clients.Add(client);

                context.SaveChanges();

                return client.Id;
            }
        }

        public void Update(Client entity)
        {
            using (var context = new ClientConfigurationDbContext(_connectionString))
            {
                var client = entity.ToEntity();

                context.UpdateGraph(client, configuration => configuration
                    .OwnedCollection(c => c.Claims)
                    .OwnedCollection(c => c.ClientSecrets)
                    .OwnedCollection(c => c.CustomGrantTypeRestrictions)
                    .OwnedCollection(c => c.IdentityProviderRestrictions)
                    .OwnedCollection(c => c.PostLogoutRedirectUris)
                    .OwnedCollection(c => c.RedirectUris)
                    .OwnedCollection(c => c.ScopeRestrictions)
                    .OwnedCollection(c => c.CustomGrantTypeRestrictions));

                context.SaveChanges();
            }
        }

        public int TotalCount()
        {
            using (var context = new ClientConfigurationDbContext(_connectionString))
            {
                var count = context.Clients.Count();

                return count;
            }
        }

        public bool IsNameAvailable(Client entity)
        {
            using (var context = new ClientConfigurationDbContext(_connectionString))
            {
                return !context.Clients.Any(c => c.ClientId == entity.ClientId && c.Id != entity.Id);
            }
        }
    }
}