using MediatR;

namespace PolicyService.Api.Queries
{
    public class GetPolicyDetailsQuery : IRequest<GetPolicyDetailsResult>
    {
        public string PolicyNumber { get; set; }
    }
}