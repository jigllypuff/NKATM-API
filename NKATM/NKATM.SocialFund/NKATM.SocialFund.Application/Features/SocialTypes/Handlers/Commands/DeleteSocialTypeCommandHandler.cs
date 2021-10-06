using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.Features.SocialTypes.Commands;
using NKATM.SocialFund.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialTypes.Handlers.Commands
{
    public class DeleteSocialTypeCommandHandler : IRequestHandler<DeleteSocialTypeCommand>
    {
        private readonly ISocialTypeRepository repository;
        private readonly IMapper mapper;

        public DeleteSocialTypeCommandHandler(ISocialTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteSocialTypeCommand request, CancellationToken cancellationToken)
        {
            var socialType = await repository.GetAsync(request.Id);
            await repository.DeleteAsync(socialType);

            return Unit.Value;
        }
    }
}
