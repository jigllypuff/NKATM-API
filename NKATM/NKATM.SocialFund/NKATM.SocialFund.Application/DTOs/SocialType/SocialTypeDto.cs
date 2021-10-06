using NKATM.SocialFund.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialType
{
    public class SocialTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int Days { get; set; }
        public string Justification { get; set; }
    }
}
