using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.Features.SocialResults.Commands;
using NKATM.SocialFund.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialResults.Handlers.Commands
{
    public class UpdateSocialResultCommandHandler : IRequestHandler<UpdateSocialResultCommand, Unit>
    {
        private readonly ISocialResultRepository repository;
        private readonly IMapper mapper;

        public UpdateSocialResultCommandHandler(ISocialResultRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateSocialResultCommand request, CancellationToken cancellationToken)
        {
            var socialResult = await repository.GetAsync(request.SocialResultDto.Id);

            mapper.Map(request.SocialResultDto, socialResult);
            await repository.UpdateAsync(socialResult);

            return Unit.Value;
        }
    }
}
