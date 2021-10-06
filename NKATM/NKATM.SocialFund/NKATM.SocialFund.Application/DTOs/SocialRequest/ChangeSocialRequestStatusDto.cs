using NKATM.SocialFund.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialRequest
{
    public class ChangeSocialRequestStatusDto : BaseDto
    {
        public bool? Approved { get; set; }
    }
}
