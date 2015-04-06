using AutoMapper;
using IdentityServer3.Admin.Persistence.Models.Storage;

namespace IdentityServer3.Admin.EntityFramework
{
    public static class Map
    {
        static Map()
        {
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.Scope, Scope>(MemberList.Destination);
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.ScopeClaim, ScopeClaim>(MemberList.Destination);
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.Client, Client>(MemberList.Destination);
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.ClientRedirectUri, ClientRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.ClientScopeRestriction, ClientScopeRestriction>(MemberList.Destination);
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.ClientPostLogoutRedirectUri, ClientPostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.ClientIdPRestriction, ClientIdPRestriction>(MemberList.Destination);
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.ClientGrantTypeRestriction, ClientGrantTypeRestriction>(
                MemberList.Destination);
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.ClientClaim, ClientClaim>(MemberList.Destination);
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.ClientSecret, ClientSecret>(MemberList.Destination);
            Mapper.CreateMap<Thinktecture.IdentityServer.EntityFramework.Entities.ClientCorsOrigin, ClientCorsOrigin>(MemberList.Destination);

            Mapper.CreateMap<Scope, Thinktecture.IdentityServer.EntityFramework.Entities.Scope>(MemberList.Destination);
            Mapper.CreateMap<ScopeClaim, Thinktecture.IdentityServer.EntityFramework.Entities.ScopeClaim>(MemberList.Destination);
            Mapper.CreateMap<Client, Thinktecture.IdentityServer.EntityFramework.Entities.Client>(MemberList.Destination);
            Mapper.CreateMap<ClientRedirectUri, Thinktecture.IdentityServer.EntityFramework.Entities.ClientRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<ClientScopeRestriction, Thinktecture.IdentityServer.EntityFramework.Entities.ClientScopeRestriction>(MemberList.Destination);
            Mapper.CreateMap<ClientPostLogoutRedirectUri, Thinktecture.IdentityServer.EntityFramework.Entities.ClientPostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<ClientIdPRestriction, Thinktecture.IdentityServer.EntityFramework.Entities.ClientIdPRestriction>(MemberList.Destination);
            Mapper.CreateMap<ClientGrantTypeRestriction, Thinktecture.IdentityServer.EntityFramework.Entities.ClientGrantTypeRestriction>(
                MemberList.Destination);
            Mapper.CreateMap<ClientClaim, Thinktecture.IdentityServer.EntityFramework.Entities.ClientClaim>(MemberList.Destination);
            Mapper.CreateMap<ClientSecret, Thinktecture.IdentityServer.EntityFramework.Entities.ClientSecret>(MemberList.Destination);
            Mapper.CreateMap<ClientCorsOrigin, Thinktecture.IdentityServer.EntityFramework.Entities.ClientCorsOrigin>(MemberList.Destination);
        }

        public static Scope ToModel(this Thinktecture.IdentityServer.EntityFramework.Entities.Scope scope)
        {
            return Mapper.Map<Scope>(scope);
        }

        public static Thinktecture.IdentityServer.EntityFramework.Entities.Scope ToEntity(this Scope scope)
        {
            return Mapper.Map<Thinktecture.IdentityServer.EntityFramework.Entities.Scope>(scope);
        }

        public static Client ToModel(this Thinktecture.IdentityServer.EntityFramework.Entities.Client client)
        {
            return Mapper.Map<Client>(client);
        }

        public static Thinktecture.IdentityServer.EntityFramework.Entities.Client ToEntity(this Client client)
        {
            return Mapper.Map<Thinktecture.IdentityServer.EntityFramework.Entities.Client>(client);
        }

        public static ClientRedirectUri ToModel(this Thinktecture.IdentityServer.EntityFramework.Entities.ClientRedirectUri clientRedirectUri)
        {
            return Mapper.Map<ClientRedirectUri>(clientRedirectUri);
        }

        public static Thinktecture.IdentityServer.EntityFramework.Entities.ClientRedirectUri ToEntity(this ClientRedirectUri clientRedirectUri)
        {
            return Mapper.Map<Thinktecture.IdentityServer.EntityFramework.Entities.ClientRedirectUri>(clientRedirectUri);
        }

        public static ClientPostLogoutRedirectUri ToModel(this Thinktecture.IdentityServer.EntityFramework.Entities.ClientPostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<ClientPostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static Thinktecture.IdentityServer.EntityFramework.Entities.ClientPostLogoutRedirectUri ToEntity(this ClientPostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<Thinktecture.IdentityServer.EntityFramework.Entities.ClientPostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static ClientIdPRestriction ToModel(this Thinktecture.IdentityServer.EntityFramework.Entities.ClientIdPRestriction identityProviderRestriction)
        {
            return Mapper.Map<ClientIdPRestriction>(identityProviderRestriction);
        }

        public static Thinktecture.IdentityServer.EntityFramework.Entities.ClientIdPRestriction ToEntity(this ClientIdPRestriction identityProviderRestriction)
        {
            return Mapper.Map<Thinktecture.IdentityServer.EntityFramework.Entities.ClientIdPRestriction>(identityProviderRestriction);
        }

        public static ClientGrantTypeRestriction ToModel(this Thinktecture.IdentityServer.EntityFramework.Entities.ClientGrantTypeRestriction clientGrantTypeRestriction)
        {
            return Mapper.Map<ClientGrantTypeRestriction>(clientGrantTypeRestriction);
        }

        public static Thinktecture.IdentityServer.EntityFramework.Entities.ClientGrantTypeRestriction ToEntity(this ClientGrantTypeRestriction clientGrantTypeRestriction)
        {
            return Mapper.Map<Thinktecture.IdentityServer.EntityFramework.Entities.ClientGrantTypeRestriction>(clientGrantTypeRestriction);
        }

        public static ClientClaim ToModel(this Thinktecture.IdentityServer.EntityFramework.Entities.ClientClaim clientClaim)
        {
            return Mapper.Map<ClientClaim>(clientClaim);
        }

        public static Thinktecture.IdentityServer.EntityFramework.Entities.ClientClaim ToEntity(this ClientClaim clientClaim)
        {
            return Mapper.Map<Thinktecture.IdentityServer.EntityFramework.Entities.ClientClaim>(clientClaim);
        }

        public static ClientSecret ToModel(this Thinktecture.IdentityServer.EntityFramework.Entities.ClientSecret clientSecret)
        {
            return Mapper.Map<ClientSecret>(clientSecret);
        }

        public static Thinktecture.IdentityServer.EntityFramework.Entities.ClientSecret ToEntity(this ClientSecret clientSecret)
        {
            return Mapper.Map<Thinktecture.IdentityServer.EntityFramework.Entities.ClientSecret>(clientSecret);
        }

        public static ClientCorsOrigin ToModel(this Thinktecture.IdentityServer.EntityFramework.Entities.ClientCorsOrigin clientCorsOrigin)
        {
            return Mapper.Map<ClientCorsOrigin>(clientCorsOrigin);
        }

        public static Thinktecture.IdentityServer.EntityFramework.Entities.ClientCorsOrigin ToEntity(this ClientCorsOrigin clientCorsOrigin)
        {
            return Mapper.Map<Thinktecture.IdentityServer.EntityFramework.Entities.ClientCorsOrigin>(clientCorsOrigin);
        }
    }
}