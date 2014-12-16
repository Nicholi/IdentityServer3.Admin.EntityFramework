using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Models.Persistence;

namespace Thinktecture.IdentityServer.v3.Admin.EntityFramework.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> ApplySkipTake<T>(this IQueryable<T> source, PagingInformation pagingInformation)
        {
            return source.Skip(pagingInformation.Skip).Take(pagingInformation.Take);
        } 

        public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, IList<SortColumn> sortColumns)
        {
            if (sortColumns == null || !sortColumns.Any())
            {
                return (IOrderedQueryable<T>) source;
            }

            var orderedQuery = OrderBy(source, sortColumns[0].Name, sortColumns[0].SortDirection);

            for (var i = 1; i < sortColumns.Count; i++)
            {
                orderedQuery = ThenBy(orderedQuery, sortColumns[i].Name, sortColumns[i].SortDirection);
            }
            
            return orderedQuery;
        }

        // From: http://stackoverflow.com/a/233505/959687, slighty changed
        public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, string property, SortDirection sortDirection)
        {
            return ApplyOrder(source, property, sortDirection, "OrderBy");
        }

        public static IOrderedQueryable<T> ThenBy<T>(this IQueryable<T> source, string property, SortDirection sortDirection)
        {
            return ApplyOrder(source, property, sortDirection, "ThenBy");
        }

        private static IOrderedQueryable<T> ApplyOrder<T>(this IQueryable<T> source, string property, SortDirection sortDirection, string methodName)
        {
            if (sortDirection == SortDirection.Ascending)
            {
                return ApplyOrder(source, property, methodName);
            }

            return ApplyOrder(source, property, methodName + "Decending");
        }
        
        private static IOrderedQueryable<T> ApplyOrder<T>(IQueryable<T> source, string property, string methodName)
        {
            var props = property.Split('.');
            var type = typeof(T);
            var arg = Expression.Parameter(type, "x");
            Expression expr = arg;
            foreach (var prop in props)
            {
                // use reflection (not ComponentModel) to mirror LINQ
                var pi = type.GetProperty(Char.ToUpper(prop[0]) + prop.Substring(1));
                expr = Expression.Property(expr, pi);
                type = pi.PropertyType;
            }
            var delegateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
            var lambda = Expression.Lambda(delegateType, expr, arg);

            var result = typeof(Queryable).GetMethods().Single(
                method => method.Name == methodName
                          && method.IsGenericMethodDefinition
                          && method.GetGenericArguments().Length == 2
                          && method.GetParameters().Length == 2)
                .MakeGenericMethod(typeof(T), type)
                .Invoke(null, new object[] { source, lambda });
            return (IOrderedQueryable<T>)result;
        }
    }
}