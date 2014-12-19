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
            Mapper.CreateMap<PostLogoutRedirectUri, WebApi.Models.Storage.PostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<IdentityProviderRestriction, WebApi.Models.Storage.IdentityProviderRestriction>(MemberList.Destination);
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

        public static WebApi.Models.Storage.PostLogoutRedirectUri ToModel(this PostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<WebApi.Models.Storage.PostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static PostLogoutRedirectUri ToEntity(this WebApi.Models.Storage.PostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<PostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static WebApi.Models.Storage.IdentityProviderRestriction ToModel(this IdentityProviderRestriction identityProviderRestriction)
        {
            return Mapper.Map<WebApi.Models.Storage.IdentityProviderRestriction>(identityProviderRestriction);
        }

        public static IdentityProviderRestriction ToEntity(this WebApi.Models.Storage.IdentityProviderRestriction identityProviderRestriction)
        {
            return Mapper.Map<IdentityProviderRestriction>(identityProviderRestriction);
        }
    }
}