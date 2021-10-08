using NKATM.SocialFund.Application.Persistance.Contracts;
using NKATM.SocialFund.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Persistance.Repositories
{
    public class SocialTypeRepository : BaseRepository<SocialType>, ISocialTypeRepository
    {
        private readonly SocialFundDbContext context;

        public SocialTypeRepository(SocialFundDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
