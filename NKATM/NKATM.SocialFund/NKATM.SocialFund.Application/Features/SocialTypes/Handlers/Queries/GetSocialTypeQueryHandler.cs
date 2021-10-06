using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialType;
using NKATM.SocialFund.Application.Features.SocialTypes.Queries;
using NKATM.SocialFund.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialTypes.Handlers.Queries
{
    public class GetSocialTypeQueryHandler : IRequestHandler<GetSocialTypeQuery, SocialTypeDto>
    {
        private readonly ISocialTypeRepository repository;
        private readonly IMapper mapper;

        public GetSocialTypeQueryHandler(ISocialTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<SocialTypeDto> Handle(GetSocialTypeQuery request, CancellationToken cancellationToken)
        {
            var socialType = await repository.GetAsync(request.Id);
            return mapper.Map<SocialTypeDto>(socialType);
        }
    }
}
