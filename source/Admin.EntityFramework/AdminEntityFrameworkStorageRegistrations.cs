using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer3.Admin.Persistence;
using Thinktecture.IdentityServer3.Admin.Persistence.Models.Storage;

namespace Thinktecture.IdentityServer3.Admin.EntityFramework
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