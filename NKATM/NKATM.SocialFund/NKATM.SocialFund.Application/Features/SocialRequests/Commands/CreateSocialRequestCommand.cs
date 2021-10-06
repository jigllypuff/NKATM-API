using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialRequests.Commands
{
    public class CreateSocialRequestCommand : IRequest<Guid>
    {
        public CreateSocialRequestDto SocialRequestDto { get; set; }
    }
}
