using AutoMapper;
using Thinktecture.IdentityServer.Core.EntityFramework.Entities;

namespace Thinktecture.IdentityServer.v3.Admin.EntityFramework
{
    public static class Map
    {
        static Map()
        {
            Mapper.CreateMap<Scope, WebApi.Models.IdentityServer.Scope>(MemberList.Destination);
            Mapper.CreateMap<ScopeClaim, WebApi.Models.IdentityServer.ScopeClaim>(MemberList.Destination);
        }

        public static WebApi.Models.IdentityServer.Scope ToModel(this Scope scope)
        {
            return Mapper.Map<WebApi.Models.IdentityServer.Scope>(scope);
        }

        public static Scope ToEntity(this WebApi.Models.IdentityServer.Scope scope)
        {
            return Mapper.Map<Scope>(scope);
        }
    }
}