using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialRequest
{
    public class UpdateSocialRequestDto : ISocialRequestDto
    {
        public Guid SocialTypeId { get; set; }
        public bool Cancelled { get; set; }
        public DateTime StartDate { get; set; }
        public string Comment { get; set; }
    }
}
