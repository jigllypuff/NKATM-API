using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialResults.Commands
{
    public class CreateSocialResultCommand : IRequest<Guid>
    {
        public CreateSocialResultDto SocialResultDto { get; set; }
    }
}