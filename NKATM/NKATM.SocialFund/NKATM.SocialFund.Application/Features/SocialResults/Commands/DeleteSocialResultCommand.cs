using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialResults.Commands
{
    public class DeleteSocialResultCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
