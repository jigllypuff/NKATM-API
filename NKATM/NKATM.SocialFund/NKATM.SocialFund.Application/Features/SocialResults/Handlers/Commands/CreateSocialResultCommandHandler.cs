using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.Features.SocialResults.Commands;
using NKATM.SocialFund.Application.Persistance.Contracts;
using NKATM.SocialFund.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialResults.Handlers.Commands
{
    public class CreateSocialResultCommandHandler : IRequestHandler<CreateSocialResultCommand, Guid>
    {
        private readonly ISocialResultRepository repository;
        private readonly IMapper mapper;

        public CreateSocialResultCommandHandler(ISocialResultRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<Guid> Handle(CreateSocialResultCommand request, CancellationToken cancellationToken)
        {
            var socialResult = mapper.Map<SocialResult>(request.SocialResultDto);
            socialResult = await repository.AddAsync(socialResult);
            return socialResult.Id;
        }
    }
}
