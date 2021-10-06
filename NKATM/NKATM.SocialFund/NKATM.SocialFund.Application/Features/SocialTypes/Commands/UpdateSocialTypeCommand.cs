using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialType;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialTypes.Commands
{
    public class UpdateSocialTypeCommand : IRequest<Unit>
    {
        public SocialTypeDto SocialTypeDto { get; set; }
    }
}
