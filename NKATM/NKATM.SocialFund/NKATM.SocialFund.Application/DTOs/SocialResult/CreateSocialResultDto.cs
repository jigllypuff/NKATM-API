﻿using NKATM.SocialFund.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialResult
{
    public class CreateSocialResultDto : ISocialResultDto
    {
        public int Days { get; set; }
        public Guid SocialTypeId { get; set; }
    }
}
