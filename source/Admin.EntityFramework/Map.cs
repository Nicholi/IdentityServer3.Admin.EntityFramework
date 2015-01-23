using AutoMapper;
using Thinktecture.IdentityServer.Core.EntityFramework.Entities;

namespace Thinktecture.IdentityServer3.Admin.EntityFramework
{
    public static class Map
    {
        static Map()
        {
            Mapper.CreateMap<Scope, IdentityServer.v3.Admin.WebApi.Models.Storage.Scope>(MemberList.Destination);
            Mapper.CreateMap<ScopeClaim, IdentityServer.v3.Admin.WebApi.Models.Storage.ScopeClaim>(MemberList.Destination);
            Mapper.CreateMap<Client, IdentityServer.v3.Admin.WebApi.Models.Storage.Client>(MemberList.Destination);
            Mapper.CreateMap<ClientRedirectUri, IdentityServer.v3.Admin.WebApi.Models.Storage.ClientRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<ClientScopeRestriction, IdentityServer.v3.Admin.WebApi.Models.Storage.ClientScopeRestriction>(MemberList.Destination);
            Mapper.CreateMap<ClientPostLogoutRedirectUri, IdentityServer.v3.Admin.WebApi.Models.Storage.ClientPostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<ClientIdPRestriction, IdentityServer.v3.Admin.WebApi.Models.Storage.ClientIdPRestriction>(MemberList.Destination);
            Mapper.CreateMap<ClientGrantTypeRestriction, IdentityServer.v3.Admin.WebApi.Models.Storage.ClientGrantTypeRestriction>(
                MemberList.Destination);
            Mapper.CreateMap<ClientClaim, IdentityServer.v3.Admin.WebApi.Models.Storage.ClientClaim>(MemberList.Destination);

            Mapper.CreateMap<IdentityServer.v3.Admin.WebApi.Models.Storage.Scope, Scope>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.v3.Admin.WebApi.Models.Storage.ScopeClaim, ScopeClaim>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.v3.Admin.WebApi.Models.Storage.Client, Client>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientRedirectUri, ClientRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientScopeRestriction, ClientScopeRestriction>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientPostLogoutRedirectUri, ClientPostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientIdPRestriction, ClientIdPRestriction>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientGrantTypeRestriction, ClientGrantTypeRestriction>(
                MemberList.Destination);
            Mapper.CreateMap<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientClaim, ClientClaim>(MemberList.Destination);
        }

        public static IdentityServer.v3.Admin.WebApi.Models.Storage.Scope ToModel(this Scope scope)
        {
            return Mapper.Map<IdentityServer.v3.Admin.WebApi.Models.Storage.Scope>(scope);
        }

        public static Scope ToEntity(this IdentityServer.v3.Admin.WebApi.Models.Storage.Scope scope)
        {
            return Mapper.Map<Scope>(scope);
        }

        public static IdentityServer.v3.Admin.WebApi.Models.Storage.Client ToModel(this Client client)
        {
            return Mapper.Map<IdentityServer.v3.Admin.WebApi.Models.Storage.Client>(client);
        }

        public static Client ToEntity(this IdentityServer.v3.Admin.WebApi.Models.Storage.Client client)
        {
            return Mapper.Map<Client>(client);
        }

        public static IdentityServer.v3.Admin.WebApi.Models.Storage.ClientRedirectUri ToModel(this ClientRedirectUri clientRedirectUri)
        {
            return Mapper.Map<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientRedirectUri>(clientRedirectUri);
        }

        public static ClientRedirectUri ToEntity(this IdentityServer.v3.Admin.WebApi.Models.Storage.ClientRedirectUri clientRedirectUri)
        {
            return Mapper.Map<ClientRedirectUri>(clientRedirectUri);
        }

        public static IdentityServer.v3.Admin.WebApi.Models.Storage.ClientPostLogoutRedirectUri ToModel(this ClientPostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientPostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static ClientPostLogoutRedirectUri ToEntity(this IdentityServer.v3.Admin.WebApi.Models.Storage.ClientPostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<ClientPostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static IdentityServer.v3.Admin.WebApi.Models.Storage.ClientIdPRestriction ToModel(this ClientIdPRestriction identityProviderRestriction)
        {
            return Mapper.Map<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientIdPRestriction>(identityProviderRestriction);
        }

        public static ClientIdPRestriction ToEntity(this IdentityServer.v3.Admin.WebApi.Models.Storage.ClientIdPRestriction identityProviderRestriction)
        {
            return Mapper.Map<ClientIdPRestriction>(identityProviderRestriction);
        }

        public static IdentityServer.v3.Admin.WebApi.Models.Storage.ClientGrantTypeRestriction ToModel(this ClientGrantTypeRestriction clientGrantTypeRestriction)
        {
            return Mapper.Map<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientGrantTypeRestriction>(clientGrantTypeRestriction);
        }

        public static ClientGrantTypeRestriction ToEntity(this IdentityServer.v3.Admin.WebApi.Models.Storage.ClientGrantTypeRestriction clientGrantTypeRestriction)
        {
            return Mapper.Map<ClientGrantTypeRestriction>(clientGrantTypeRestriction);
        }

        public static IdentityServer.v3.Admin.WebApi.Models.Storage.ClientClaim ToModel(this ClientClaim clientClaim)
        {
            return Mapper.Map<IdentityServer.v3.Admin.WebApi.Models.Storage.ClientClaim>(clientClaim);
        }

        public static ClientClaim ToEntity(this IdentityServer.v3.Admin.WebApi.Models.Storage.ClientClaim clientClaim)
        {
            return Mapper.Map<ClientClaim>(clientClaim);
        }
    }
}