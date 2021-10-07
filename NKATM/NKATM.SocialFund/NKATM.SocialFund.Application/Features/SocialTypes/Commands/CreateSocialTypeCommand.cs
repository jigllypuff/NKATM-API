using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialType;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialTypes.Commands
{
    public class CreateSocialTypeCommand : IRequest<Guid>
    {
        public CreateSocialTypeDto SocialTypeDto { get; set; }
    }
}
