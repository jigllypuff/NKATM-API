using NKATM.SocialFund.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Domain
{
    public class SocialResult : BaseEntity
    {
        public SocialType SocialType { get; set; }
        public Guid SocialTypeId { get; set; }
        public int Days { get; set; }
    }
}
