using MediatR;
using PolicySearchService.Domain;
using System.Threading;
using System.Threading.Tasks;
using PolicyService.Api.Events;

namespace PolicySearchService.Listeners
{
    public class PolicyCreatedHandler : INotificationHandler<PolicyCreated>
    {
        private readonly IPolicyRepository _policies;

        public PolicyCreatedHandler(IPolicyRepository policies)
        {
            _policies = policies;
        }

        public async Task Handle(PolicyCreated notification, CancellationToken cancellationToken)
        {
            await _policies.Add(new Policy
            {
                PolicyNumber = notification.PolicyNumber,
                PolicyStartDate = notification.PolicyFrom,
                PolicyEndDate = notification.PolicyTo,
                ProductCode = notification.ProductCode,
                PolicyHolder = $"{notification.PolicyHolder.FirstName} {notification.PolicyHolder.LastName}",
                PremiumAmount = notification.TotalPremium,
            });
        }
    }
}