using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Models.Storage;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Storage;

namespace Thinktecture.IdentityServer.v3.Admin.EntityFramework
{
    public class AdminEntityFrameworkStorageRegistrations : StorageRegistrations
    {
        private readonly string _connectionString;

        public AdminEntityFrameworkStorageRegistrations(string connectionString)
        {
            _connectionString = connectionString;
        }

        public override Registration<IPersistence<Scope>> ScopePersistence
        {
            get { return new Registration<IPersistence<Scope>>(context => new ScopePersistence(_connectionString)); }
        }

        public override Registration<IPersistence<Client>> ClientPersistence
        {
            get { return new Registration<IPersistence<Client>>(context => new ClientPersistence(_connectionString)); }
        }
    }
}