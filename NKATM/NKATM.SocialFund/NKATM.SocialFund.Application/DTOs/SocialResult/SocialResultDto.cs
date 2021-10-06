using NKATM.SocialFund.Application.DTOs.Common;
using NKATM.SocialFund.Application.DTOs.SocialType;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialResult
{
    public class SocialResultDto : BaseDto
    {
        public SocialTypeDto SocialType { get; set; }
        public Guid SocialTypeId { get; set; }
        public int Days { get; set; }
    }
}
