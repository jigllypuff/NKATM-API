using Microsoft.EntityFrameworkCore;
using NKATM.SocialFund.Application.Persistance.Contracts;
using NKATM.SocialFund.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Persistance.Repositories
{
    class SocialRequestRepository : BaseRepository<SocialRequest>, ISocialRequestRepository
    {
        private readonly SocialFundDbContext context;

        public SocialRequestRepository(SocialFundDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task ChangeSocialRequestStatus(SocialRequest socialRequest, bool? status)
        {
            socialRequest.Approved = status;
            context.Entry(socialRequest).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task<SocialRequest> GetSocialRequestWithDetails(Guid id)
        {
            return await context.SocialRequests
                        .Include(t => t.SocialType)
                        .FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}
