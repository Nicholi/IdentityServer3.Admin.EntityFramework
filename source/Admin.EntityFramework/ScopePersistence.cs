using System;
using System.Data.Entity;
using System.Linq;
using Thinktecture.IdentityServer.Core.EntityFramework;
using Thinktecture.IdentityServer.v3.Admin.Storage;
using Thinktecture.IdentityServer.v3.Admin.Storage.Models.IdentityServer;
using Thinktecture.IdentityServer.v3.Admin.Storage.Models.Persistence;

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
            throw new NotImplementedException();
        }

        public Scope Get(int key)
        {
            using (var context = new ConfigurationDbContext(_connectionString))
            {
                var scope = context.Scopes.FirstOrDefault(i => i.Id == key);

                return scope.ToModel();
            }
        }

        public void Delete(int key)
        {
            using (var context = new ConfigurationDbContext(_connectionString))
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
            using (var context = new ConfigurationDbContext(_connectionString))
            {
                var scope = entity.ToEntity();
                context.Scopes.Add(scope);

                context.SaveChanges();
            }
        }

        public void Update(Scope entity)
        {
            using (var context = new ConfigurationDbContext(_connectionString))
            {
                var scope = entity.ToEntity();

                if (context.Entry(scope).State == EntityState.Detached)
                {
                    context.Scopes.Attach(scope);
                    context.Entry(scope).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
        }
    }
}