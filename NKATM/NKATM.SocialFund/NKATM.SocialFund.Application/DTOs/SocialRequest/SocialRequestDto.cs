using NKATM.SocialFund.Application.DTOs.Common;
using NKATM.SocialFund.Application.DTOs.SocialType;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialRequest
{
    public class SocialRequestDto : BaseDto
    {
        public Guid SocialTypeId { get; set; }
        public SocialTypeDto SocialType { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
    }
}
