using AutoMapper;
using Thinktecture.IdentityServer.Core.EntityFramework.Entities;

namespace Thinktecture.IdentityServer.v3.Admin.EntityFramework
{
    public static class Map
    {
        static Map()
        {
            Mapper.CreateMap<Scope, Storage.Models.IdentityServer.Scope>(MemberList.Destination);
            Mapper.CreateMap<ScopeClaim, Storage.Models.IdentityServer.ScopeClaim>(MemberList.Destination);
        }

        public static Storage.Models.IdentityServer.Scope ToModel(this Scope scope)
        {
            return Mapper.Map<Storage.Models.IdentityServer.Scope>(scope);
        }

        public static Scope ToEntity(this Storage.Models.IdentityServer.Scope scope)
        {
            return Mapper.Map<Scope>(scope);
        }
    }
}