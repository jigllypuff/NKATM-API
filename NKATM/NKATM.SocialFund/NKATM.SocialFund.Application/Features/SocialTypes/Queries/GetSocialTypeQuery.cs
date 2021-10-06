using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialType;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialTypes.Queries
{
    public class GetSocialTypeQuery : IRequest<SocialTypeDto>
    {
        public Guid Id { get; set; }
    }
}
