using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialTypes.Commands
{
    public class DeleteSocialTypeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
