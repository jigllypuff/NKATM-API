using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ModificationDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModificationBy { get; set; }
    }
}
