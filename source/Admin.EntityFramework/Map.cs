using AutoMapper;
using Thinktecture.IdentityServer3.Admin.WebApi.Models.Storage;
using ClientScopeRestriction = Thinktecture.IdentityServer.EntityFramework.Entities.ClientScopeRestriction;
using ScopeClaim = Thinktecture.IdentityServer.EntityFramework.Entities.ScopeClaim;

namespace Thinktecture.IdentityServer3.Admin.EntityFramework
{
    public static class Map
    {
        static Map()
        {
            Mapper.CreateMap<IdentityServer.EntityFramework.Entities.Scope, Scope>(MemberList.Destination);
            Mapper.CreateMap<ScopeClaim, WebApi.Models.Storage.ScopeClaim>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.EntityFramework.Entities.Client, Client>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.EntityFramework.Entities.ClientRedirectUri, ClientRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<ClientScopeRestriction, WebApi.Models.Storage.ClientScopeRestriction>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.EntityFramework.Entities.ClientPostLogoutRedirectUri, ClientPostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.EntityFramework.Entities.ClientIdPRestriction, ClientIdPRestriction>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer.EntityFramework.Entities.ClientGrantTypeRestriction, ClientGrantTypeRestriction>(
                MemberList.Destination);
            Mapper.CreateMap<IdentityServer.EntityFramework.Entities.ClientClaim, ClientClaim>(MemberList.Destination);

            Mapper.CreateMap<Scope, IdentityServer.EntityFramework.Entities.Scope>(MemberList.Destination);
            Mapper.CreateMap<WebApi.Models.Storage.ScopeClaim, ScopeClaim>(MemberList.Destination);
            Mapper.CreateMap<Client, IdentityServer.EntityFramework.Entities.Client>(MemberList.Destination);
            Mapper.CreateMap<ClientRedirectUri, IdentityServer.EntityFramework.Entities.ClientRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<WebApi.Models.Storage.ClientScopeRestriction, ClientScopeRestriction>(MemberList.Destination);
            Mapper.CreateMap<ClientPostLogoutRedirectUri, IdentityServer.EntityFramework.Entities.ClientPostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<ClientIdPRestriction, IdentityServer.EntityFramework.Entities.ClientIdPRestriction>(MemberList.Destination);
            Mapper.CreateMap<ClientGrantTypeRestriction, IdentityServer.EntityFramework.Entities.ClientGrantTypeRestriction>(
                MemberList.Destination);
            Mapper.CreateMap<ClientClaim, IdentityServer.EntityFramework.Entities.ClientClaim>(MemberList.Destination);
        }

        public static Scope ToModel(this IdentityServer.EntityFramework.Entities.Scope scope)
        {
            return Mapper.Map<Scope>(scope);
        }

        public static IdentityServer.EntityFramework.Entities.Scope ToEntity(this Scope scope)
        {
            return Mapper.Map<IdentityServer.EntityFramework.Entities.Scope>(scope);
        }

        public static Client ToModel(this IdentityServer.EntityFramework.Entities.Client client)
        {
            return Mapper.Map<Client>(client);
        }

        public static IdentityServer.EntityFramework.Entities.Client ToEntity(this Client client)
        {
            return Mapper.Map<IdentityServer.EntityFramework.Entities.Client>(client);
        }

        public static ClientRedirectUri ToModel(this IdentityServer.EntityFramework.Entities.ClientRedirectUri clientRedirectUri)
        {
            return Mapper.Map<ClientRedirectUri>(clientRedirectUri);
        }

        public static IdentityServer.EntityFramework.Entities.ClientRedirectUri ToEntity(this ClientRedirectUri clientRedirectUri)
        {
            return Mapper.Map<IdentityServer.EntityFramework.Entities.ClientRedirectUri>(clientRedirectUri);
        }

        public static ClientPostLogoutRedirectUri ToModel(this IdentityServer.EntityFramework.Entities.ClientPostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<ClientPostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static IdentityServer.EntityFramework.Entities.ClientPostLogoutRedirectUri ToEntity(this ClientPostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<IdentityServer.EntityFramework.Entities.ClientPostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static ClientIdPRestriction ToModel(this IdentityServer.EntityFramework.Entities.ClientIdPRestriction identityProviderRestriction)
        {
            return Mapper.Map<ClientIdPRestriction>(identityProviderRestriction);
        }

        public static IdentityServer.EntityFramework.Entities.ClientIdPRestriction ToEntity(this ClientIdPRestriction identityProviderRestriction)
        {
            return Mapper.Map<IdentityServer.EntityFramework.Entities.ClientIdPRestriction>(identityProviderRestriction);
        }

        public static ClientGrantTypeRestriction ToModel(this IdentityServer.EntityFramework.Entities.ClientGrantTypeRestriction clientGrantTypeRestriction)
        {
            return Mapper.Map<ClientGrantTypeRestriction>(clientGrantTypeRestriction);
        }

        public static IdentityServer.EntityFramework.Entities.ClientGrantTypeRestriction ToEntity(this ClientGrantTypeRestriction clientGrantTypeRestriction)
        {
            return Mapper.Map<IdentityServer.EntityFramework.Entities.ClientGrantTypeRestriction>(clientGrantTypeRestriction);
        }

        public static ClientClaim ToModel(this IdentityServer.EntityFramework.Entities.ClientClaim clientClaim)
        {
            return Mapper.Map<ClientClaim>(clientClaim);
        }

        public static IdentityServer.EntityFramework.Entities.ClientClaim ToEntity(this ClientClaim clientClaim)
        {
            return Mapper.Map<IdentityServer.EntityFramework.Entities.ClientClaim>(clientClaim);
        }
    }
}