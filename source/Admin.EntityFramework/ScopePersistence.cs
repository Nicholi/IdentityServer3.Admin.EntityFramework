﻿using System;
using System.Linq;
using IdentityServer3.Admin.EntityFramework.Extensions;
using RefactorThis.GraphDiff;
using Thinktecture.IdentityServer.EntityFramework;
using IdentityServer3.Admin.Persistence;
using IdentityServer3.Admin.Persistence.Models;
using IdentityServer3.Admin.Persistence.Models.Storage;

namespace IdentityServer3.Admin.EntityFramework
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
                var scopesQuery = (IQueryable<Thinktecture.IdentityServer.EntityFramework.Entities.Scope>) context.Scopes
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
                var entity = new Thinktecture.IdentityServer.EntityFramework.Entities.Scope()
                {
                    Id = key
                };

                context.Scopes.Attach(entity);
                context.Scopes.Remove(entity);

                context.SaveChanges();
            }
        }

        public object Add(Scope entity)
        {
            using (var context = new ScopeConfigurationDbContext(_connectionString))
            {
                var scope = entity.ToEntity();
                context.Scopes.Add(scope);

                context.SaveChanges();

                return scope.Id;
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

        public int TotalCount()
        {
            using (var context = new ScopeConfigurationDbContext(_connectionString))
            {
                var count = context.Scopes.Count();

                return count;
            }
        }

        public bool IsNameAvailable(Scope entity)
        {
            using (var context = new ScopeConfigurationDbContext(_connectionString))
            {
                return !context.Scopes.Any(s => s.Name == entity.Name && s.Id != entity.Id);
            }
        }
    }
}