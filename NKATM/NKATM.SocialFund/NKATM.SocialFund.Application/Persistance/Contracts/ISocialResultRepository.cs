using NKATM.SocialFund.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Persistance.Contracts
{
    public interface ISocialResultRepository : IBaseRepository<SocialResult>
    {
        Task<SocialResult> GetSocialResultWithDetails(Guid id);
    }
}
