using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Features.SocialRequests.Queries
{
    public class GetSocialRequestQuery : IRequest<SocialRequestDto>
    {
        public Guid Id { get; set; }
    }
}
