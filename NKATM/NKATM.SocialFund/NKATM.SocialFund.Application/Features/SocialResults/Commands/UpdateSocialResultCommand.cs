using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialResults.Commands
{
    public class UpdateSocialResultCommand : IRequest<Unit>
    {
        public UpdateSocialResultDto SocialResultDto { get; set; }
    }
}
