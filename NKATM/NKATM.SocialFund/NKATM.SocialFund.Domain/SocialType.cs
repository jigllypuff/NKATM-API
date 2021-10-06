using NKATM.SocialFund.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Domain
{
    public class SocialType : BaseEntity
    {
        public string Name { get; set; }
        public int Days { get; set; }
        public string Justification { get; set; }
    }
}
