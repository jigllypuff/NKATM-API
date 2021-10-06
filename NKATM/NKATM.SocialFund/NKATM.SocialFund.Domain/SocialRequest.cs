using NKATM.SocialFund.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Domain
{
    public class SocialRequest : BaseEntity
    {
        public Guid SocialTypeId { get; set; }
        public SocialType SocialType { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
    }
}
