using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer.v3.Admin.Storage;
using Thinktecture.IdentityServer.v3.Admin.Storage.Models.IdentityServer;

namespace Thinktecture.IdentityServer.v3.Admin.EntityFramework
{
    public class AdminEntityFrameworkStorageRegistrations : StorageRegistrations
    {
        private readonly string _connectionString;

        public AdminEntityFrameworkStorageRegistrations(string connectionString)
        {
            _connectionString = connectionString;
        }

        public override Registration<IPersistence<Scope>> ScopeStore
        {
            get { return Registration.RegisterSingleton<IPersistence<Scope>>(new ScopePersistence(_connectionString)); }
        }
    }
}