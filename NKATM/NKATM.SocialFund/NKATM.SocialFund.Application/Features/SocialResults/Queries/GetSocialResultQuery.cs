using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialResults.Queries
{
    public class GetSocialResultQuery : IRequest<SocialResultDto>
    {
        public Guid Id { get; set; }
    }
}
