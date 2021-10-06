using NKATM.SocialFund.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Persistance.Contracts
{
    public interface ISocialRequestRepository : IBaseRepository<SocialRequest>
    {
        Task<SocialRequest> GetSocialRequestWithDetails(Guid id);
        Task ChangeSocialRequestStatus(SocialRequest socialRequest, bool? Status);
    }
}
