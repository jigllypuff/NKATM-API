using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.Exceptions;
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
    public class DeleteSocialResultCommandHandler : IRequestHandler<DeleteSocialResultCommand>
    {
        private readonly ISocialResultRepository repository;
        private readonly IMapper mapper;

        public DeleteSocialResultCommandHandler(ISocialResultRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteSocialResultCommand request, CancellationToken cancellationToken)
        {
            var socialResult = await repository.GetAsync(request.Id);

            if (socialResult == null)
            {
                throw new NotFoundException(nameof(SocialResult), request.Id);
            }

            await repository.DeleteAsync(socialResult);

            return Unit.Value;
        }
    }
}
