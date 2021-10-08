using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialResult
{
    public interface ISocialResultDto
    {
        public Guid SocialTypeId { get; set; }
        public int Days { get; set; }
    }
}
