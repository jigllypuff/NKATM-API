using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialType
{
    public class CreateSocialTypeDto : ISocialTypeDto
    {
        public string Name { get; set; }
        public int Days { get; set; }
        public string Justification { get; set; }
    }
}
