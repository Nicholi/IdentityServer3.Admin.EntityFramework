using System;
using System.Data.Entity;
using System.Linq;
using RefactorThis.GraphDiff;
using Thinktecture.IdentityServer.Core.EntityFramework;
using Thinktecture.IdentityServer.v3.Admin.EntityFramework.Extensions;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Models.Persistence;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Models.Storage;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Storage;

namespace Thinktecture.IdentityServer.v3.Admin.EntityFramework
{
    public class ScopePersistence : IPersistence<Scope>
    {
        private readonly string _connectionString;

        public ScopePersistence(string connectionString)
        {
            _connectionString = connectionString;
        }

        public PageResult<Scope> List(PagingInformation pagingInformation)
        {
            using (var context = new ScopeConfigurationDbContext(_connectionString))
            {
                var scopesQuery = (IQueryable<Core.EntityFramework.Entities.Scope>) context.Scopes
                    .AsNoTracking();

                if (!String.IsNullOrEmpty(pagingInformation.SearchTerm))
                {
                    scopesQuery = scopesQuery.Where(s => s.DisplayName.Contains(pagingInformation.SearchTerm));
                }

                scopesQuery = scopesQuery.OrderBy(pagingInformation.SortColumns);

                var result = new PageResult<Scope>()
                {
                    Items = scopesQuery.ApplySkipTake(pagingInformation).ToList().Select(i => i.ToModel()).ToList(),
                    TotalCount = scopesQuery.Count(),
                };

                return result;
            }
        }

        public Scope Get(int key)
        {
            using (var context = new ScopeConfigurationDbContext(_connectionString))
            {
                var scope = context.Scopes.FirstOrDefault(i => i.Id == key);

                return scope.ToModel();
            }
        }

        public void Delete(int key)
        {
            using (var context = new ScopeConfigurationDbContext(_connectionString))
            {
                context.Scopes.Remove(new Core.EntityFramework.Entities.Scope()
                {
                    Id = key
                });

                context.SaveChanges();
            }
        }

        public void Add(Scope entity)
        {
            using (var context = new ScopeConfigurationDbContext(_connectionString))
            {
                var scope = entity.ToEntity();
                context.Scopes.Add(scope);

                context.SaveChanges();
            }
        }

        public void Update(Scope entity)
        {
            using (var context = new ScopeConfigurationDbContext(_connectionString))
            {
                var scope = entity.ToEntity();

                context.UpdateGraph(scope, configuration => configuration.OwnedCollection(p => p.ScopeClaims));

                context.SaveChanges();
            }
        }
    }
}