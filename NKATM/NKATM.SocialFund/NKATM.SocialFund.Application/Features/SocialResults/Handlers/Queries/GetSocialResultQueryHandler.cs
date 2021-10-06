using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialResult;
using NKATM.SocialFund.Application.Features.SocialResults.Queries;
using NKATM.SocialFund.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialResults.Handlers.Queries
{
    public class GetSocialResultQueryHandler : IRequestHandler<GetSocialResultQuery, SocialResultDto>
    {
        private readonly ISocialResultRepository repository;
        private readonly IMapper mapper;

        public GetSocialResultQueryHandler(ISocialResultRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<SocialResultDto> Handle(GetSocialResultQuery request, CancellationToken cancellationToken)
        {
            var socialResult = await repository.GetSocialResultWithDetails(request.Id);
            return mapper.Map<SocialResultDto>(socialResult);
        }
    }
}
