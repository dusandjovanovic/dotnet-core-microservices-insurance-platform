using System;
using System.Threading.Tasks;

namespace PolicyService.Domain
{
    public interface IUnitOfWork
    {
        IOfferRepository Offers { get; }

        IPolicyRepository Policies { get; }

        Task CommitChanges();
    }
}