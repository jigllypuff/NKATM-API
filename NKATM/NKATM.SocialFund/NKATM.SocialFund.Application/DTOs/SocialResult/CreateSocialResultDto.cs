using NKATM.SocialFund.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialResult
{
    public class CreateSocialResultDto
    {
        public int NumberOfDays { get; set; }
        public Guid SocialTypeId { get; set; }
    }
}
