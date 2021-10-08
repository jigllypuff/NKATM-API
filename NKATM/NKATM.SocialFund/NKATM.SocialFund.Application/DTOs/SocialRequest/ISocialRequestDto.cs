using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialRequest
{
    public interface ISocialRequestDto
    {
        public Guid SocialTypeId { get; set; }
        public string Comment { get; set; }
        public DateTime StartDate { get; set; }
    }
}
