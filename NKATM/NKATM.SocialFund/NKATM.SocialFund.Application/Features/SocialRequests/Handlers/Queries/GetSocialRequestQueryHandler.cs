using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialRequest;
using NKATM.SocialFund.Application.Features.SocialRequests.Queries;
using NKATM.SocialFund.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialRequests.Handlers.Queries
{
    public class GetSocialRequestQueryHandler : IRequestHandler<GetSocialRequestQuery, SocialRequestDto>
    {
        private readonly ISocialRequestRepository repository;
        private readonly IMapper mapper;

        public GetSocialRequestQueryHandler(ISocialRequestRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<SocialRequestDto> Handle(GetSocialRequestQuery request, CancellationToken cancellationToken)
        {
            var socialRequest = await repository.GetSocialRequestWithDetails(request.Id);
            return mapper.Map<SocialRequestDto>(socialRequest);
        }
    }
}
