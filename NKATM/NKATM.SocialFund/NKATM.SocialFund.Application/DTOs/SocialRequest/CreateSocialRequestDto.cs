using NKATM.SocialFund.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialRequest
{
    public class CreateSocialRequestDto
    {
        public Guid SocialTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string Comment { get; set; }
    }
}
