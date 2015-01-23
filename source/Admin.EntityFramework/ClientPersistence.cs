using System;
using System.Linq;
using RefactorThis.GraphDiff;
using Thinktecture.IdentityServer.Core.EntityFramework;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Models.Persistence;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Models.Storage;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Storage;
using Thinktecture.IdentityServer3.Admin.EntityFramework.Extensions;

namespace Thinktecture.IdentityServer3.Admin.EntityFramework
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
                var clientQuery = (IQueryable<IdentityServer.Core.EntityFramework.Entities.Client>) context.Clients
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
                context.Clients.Remove(new IdentityServer.Core.EntityFramework.Entities.Client()
                {
                    Id = key
                });

                context.SaveChanges();
            }
        }

        public void Add(Client entity)
        {
            using (var context = new ClientConfigurationDbContext(_connectionString))
            {
                var client = entity.ToEntity();
                context.Clients.Add(client);

                context.SaveChanges();
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
    }
}