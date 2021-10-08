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
    public class SocialResultRepository : BaseRepository<SocialResult>, ISocialResultRepository
    {
        private readonly SocialFundDbContext context;

        public SocialResultRepository(SocialFundDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<SocialResult> GetSocialResultWithDetails(Guid id)
        {
            return await context.SocialResults
                        .Include(t => t.SocialType)
                        .FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}
