using AutoMapper;
using IdentityServer3.Admin.Persistence.Models.Storage;

namespace IdentityServer3.Admin.EntityFramework
{
    public static class Map
    {
        static Map()
        {
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.Scope, Scope>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.ScopeClaim, ScopeClaim>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.Client, Client>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.ClientRedirectUri, ClientRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.ClientScope, ClientScope>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.ClientPostLogoutRedirectUri, ClientPostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.ClientIdPRestriction, ClientIdPRestriction>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.ClientCustomGrantType, ClientCustomGrantType>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.ClientClaim, ClientClaim>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.ClientSecret, ClientSecret>(MemberList.Destination);
            Mapper.CreateMap<IdentityServer3.EntityFramework.Entities.ClientCorsOrigin, ClientCorsOrigin>(MemberList.Destination);

            Mapper.CreateMap<Scope, IdentityServer3.EntityFramework.Entities.Scope>(MemberList.Destination);
            Mapper.CreateMap<ScopeClaim, IdentityServer3.EntityFramework.Entities.ScopeClaim>(MemberList.Destination);
            Mapper.CreateMap<Client, IdentityServer3.EntityFramework.Entities.Client>(MemberList.Destination);
            Mapper.CreateMap<ClientRedirectUri, IdentityServer3.EntityFramework.Entities.ClientRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<ClientScope, IdentityServer3.EntityFramework.Entities.ClientScope>(MemberList.Destination);
            Mapper.CreateMap<ClientPostLogoutRedirectUri, IdentityServer3.EntityFramework.Entities.ClientPostLogoutRedirectUri>(MemberList.Destination);
            Mapper.CreateMap<ClientIdPRestriction, IdentityServer3.EntityFramework.Entities.ClientIdPRestriction>(MemberList.Destination);
            Mapper.CreateMap<ClientCustomGrantType, IdentityServer3.EntityFramework.Entities.ClientCustomGrantType>(MemberList.Destination);
            Mapper.CreateMap<ClientClaim, IdentityServer3.EntityFramework.Entities.ClientClaim>(MemberList.Destination);
            Mapper.CreateMap<ClientSecret, IdentityServer3.EntityFramework.Entities.ClientSecret>(MemberList.Destination);
            Mapper.CreateMap<ClientCorsOrigin, IdentityServer3.EntityFramework.Entities.ClientCorsOrigin>(MemberList.Destination);
        }

        public static Scope ToModel(this IdentityServer3.EntityFramework.Entities.Scope scope)
        {
            return Mapper.Map<Scope>(scope);
        }

        public static IdentityServer3.EntityFramework.Entities.Scope ToEntity(this Scope scope)
        {
            return Mapper.Map<IdentityServer3.EntityFramework.Entities.Scope>(scope);
        }

        public static Client ToModel(this IdentityServer3.EntityFramework.Entities.Client client)
        {
            return Mapper.Map<Client>(client);
        }

        public static IdentityServer3.EntityFramework.Entities.Client ToEntity(this Client client)
        {
            return Mapper.Map<IdentityServer3.EntityFramework.Entities.Client>(client);
        }

        public static ClientRedirectUri ToModel(this IdentityServer3.EntityFramework.Entities.ClientRedirectUri clientRedirectUri)
        {
            return Mapper.Map<ClientRedirectUri>(clientRedirectUri);
        }

        public static IdentityServer3.EntityFramework.Entities.ClientRedirectUri ToEntity(this ClientRedirectUri clientRedirectUri)
        {
            return Mapper.Map<IdentityServer3.EntityFramework.Entities.ClientRedirectUri>(clientRedirectUri);
        }

        public static ClientPostLogoutRedirectUri ToModel(this IdentityServer3.EntityFramework.Entities.ClientPostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<ClientPostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static IdentityServer3.EntityFramework.Entities.ClientPostLogoutRedirectUri ToEntity(this ClientPostLogoutRedirectUri postLogoutRedirectUri)
        {
            return Mapper.Map<IdentityServer3.EntityFramework.Entities.ClientPostLogoutRedirectUri>(postLogoutRedirectUri);
        }

        public static ClientIdPRestriction ToModel(this IdentityServer3.EntityFramework.Entities.ClientIdPRestriction identityProviderRestriction)
        {
            return Mapper.Map<ClientIdPRestriction>(identityProviderRestriction);
        }

        public static IdentityServer3.EntityFramework.Entities.ClientIdPRestriction ToEntity(this ClientIdPRestriction identityProviderRestriction)
        {
            return Mapper.Map<IdentityServer3.EntityFramework.Entities.ClientIdPRestriction>(identityProviderRestriction);
        }

        public static ClientCustomGrantType ToModel(this IdentityServer3.EntityFramework.Entities.ClientCustomGrantType clientGrantTypeRestriction)
        {
            return Mapper.Map<ClientCustomGrantType>(clientGrantTypeRestriction);
        }

        public static IdentityServer3.EntityFramework.Entities.ClientCustomGrantType ToEntity(this ClientCustomGrantType clientGrantTypeRestriction)
        {
            return Mapper.Map<IdentityServer3.EntityFramework.Entities.ClientCustomGrantType>(clientGrantTypeRestriction);
        }

        public static ClientClaim ToModel(this IdentityServer3.EntityFramework.Entities.ClientClaim clientClaim)
        {
            return Mapper.Map<ClientClaim>(clientClaim);
        }

        public static IdentityServer3.EntityFramework.Entities.ClientClaim ToEntity(this ClientClaim clientClaim)
        {
            return Mapper.Map<IdentityServer3.EntityFramework.Entities.ClientClaim>(clientClaim);
        }

        public static ClientSecret ToModel(this IdentityServer3.EntityFramework.Entities.ClientSecret clientSecret)
        {
            return Mapper.Map<ClientSecret>(clientSecret);
        }

        public static IdentityServer3.EntityFramework.Entities.ClientSecret ToEntity(this ClientSecret clientSecret)
        {
            return Mapper.Map<IdentityServer3.EntityFramework.Entities.ClientSecret>(clientSecret);
        }

        public static ClientCorsOrigin ToModel(this IdentityServer3.EntityFramework.Entities.ClientCorsOrigin clientCorsOrigin)
        {
            return Mapper.Map<ClientCorsOrigin>(clientCorsOrigin);
        }

        public static IdentityServer3.EntityFramework.Entities.ClientCorsOrigin ToEntity(this ClientCorsOrigin clientCorsOrigin)
        {
            return Mapper.Map<IdentityServer3.EntityFramework.Entities.ClientCorsOrigin>(clientCorsOrigin);
        }

        public static ClientScope ToModel(this IdentityServer3.EntityFramework.Entities.ClientScope clientScope)
        {
            return Mapper.Map<ClientScope>(clientScope);
        }

        public static IdentityServer3.EntityFramework.Entities.ClientScope ToEntity(this ClientScope clientScope)
        {
            return Mapper.Map<IdentityServer3.EntityFramework.Entities.ClientScope>(clientScope);
        }
    }
}