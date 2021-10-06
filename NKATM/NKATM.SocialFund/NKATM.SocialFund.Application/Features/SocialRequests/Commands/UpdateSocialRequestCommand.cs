using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialRequests.Commands
{
    public class UpdateSocialRequestCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public SocialRequestDto SocialRequestDto { get; set; }
        public ChangeSocialRequestStatusDto ChangeSocialRequestStatusDto { get; set; }
    }
}
