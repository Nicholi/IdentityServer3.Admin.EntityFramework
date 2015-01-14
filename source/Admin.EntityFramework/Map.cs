using AutoMapper;
using Thinktecture.IdentityServer.Core.EntityFramework.Entities;

namespace Thinktecture.IdentityServer.v3.Admin.EntityFramework
{
    public static class Map
    {
        static Map()
        {
            Mapper.CreateMap<Scope, WebApi.Models.Storage.Scope>(MemberList.Destination);
            Mapper.CreateMap<ScopeClaim, WebApi.Models.Storage.ScopeClaim>(MemberList.Destination);
            Mapper.CreateMap<Client, WebApi.Models.Storage.Client>(MemberList.Destination);
            Mapper.CreateMap<ClientRedirectUri, WebApi.Models.Storage.ClientRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<ClientScopeRestriction, WebApi.Models.Storage.ClientScopeRestriction>(MemberList.Destination);
            Mapper.CreateMap<ClientPostLogoutRedirectUri, WebApi.Models.Storage.ClientPostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<ClientIdPRestriction, WebApi.Models.Storage.ClientIdPRestriction>(MemberList.Destination);

            Mapper.CreateMap<WebApi.Models.Storage.Scope, Scope>(MemberList.Destination);
            Mapper.CreateMap<WebApi.Models.Storage.ScopeClaim, ScopeClaim>(MemberList.Destination);
            Mapper.CreateMap<WebApi.Models.Storage.Client, Client>(MemberList.Destination);
            Mapper.CreateMap<WebApi.Models.Storage.ClientRedirectUri, ClientRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<WebApi.Models.Storage.ClientScopeRestriction, ClientScopeRestriction>(MemberList.Destination);
            Mapper.CreateMap<WebApi.Models.Storage.ClientPostLogoutRedirectUri, ClientPostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<WebApi.Models.Storage.ClientIdPRestriction, ClientIdPRestriction>(MemberList.Destination);
        }

        public static WebApi.Models.Storage.Scope ToModel(this Scope scope)
        {
            return Mapper.Map<WebApi.Models.Storage.Scope>(scope);
        }

        public static Scope ToEntity(this WebApi.Models.Storage.Scope scope)
        {
            return Mapper.Map<Scope>(scope);
        }

        public static WebApi.Models.Storage.Client ToModel(this Client client)
        {
            return Mapper.Map<WebApi.Models.Storage.Client>(client);
        }

        public static Client ToEntity(this WebApi.Models.Storage.Client client)
        {
            return Mapper.Map<Client>(client);
        }

        public static WebApi.Models.Storage.ClientRedirectUri ToModel(this ClientRedirectUri clientRedirectUri)
        {
            return Mapper.Map<WebApi.Models.Storage.ClientRedirectUri>(clientRedirectUri);
        }

        public static ClientRedirectUri ToEntity(this WebApi.Models.Storage.ClientRedirectUri clientRedirectUri)
        {
            return Mapper.Map<ClientRedirectUri>(clientRedirectUri);
        }

        public static WebApi.Models.Storage.ClientPostLogoutRedirectUri ToModel(this ClientPostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<WebApi.Models.Storage.ClientPostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static ClientPostLogoutRedirectUri ToEntity(this WebApi.Models.Storage.ClientPostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<ClientPostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static WebApi.Models.Storage.ClientIdPRestriction ToModel(this ClientIdPRestriction identityProviderRestriction)
        {
            return Mapper.Map<WebApi.Models.Storage.ClientIdPRestriction>(identityProviderRestriction);
        }

        public static ClientIdPRestriction ToEntity(this WebApi.Models.Storage.ClientIdPRestriction identityProviderRestriction)
        {
            return Mapper.Map<ClientIdPRestriction>(identityProviderRestriction);
        }
    }
}