using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialRequests.Commands
{
    public class DeleteSocialRequestCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
