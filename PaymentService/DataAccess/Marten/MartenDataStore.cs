using Marten;
using PaymentService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.DataAccess.Marten
{
    public class MartenDataStore : IDataStore
    {
        private readonly IDocumentSession session;

        public MartenDataStore(IDocumentStore documentStore)
        {
            session = documentStore.LightweightSession();
            PolicyAccounts = new MartenPolicyAccountRepository(session);
        }

        public IPolicyAccountRepository PolicyAccounts { get; }

        public async Task CommitChanges()
        {
            await session.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                session.Dispose();
            }

        }
    }
}
