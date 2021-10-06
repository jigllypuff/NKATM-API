using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.Features.SocialRequests.Commands;
using NKATM.SocialFund.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialRequests.Handlers.Commands
{
    public class DeleteSocialRequestCommandHandler : IRequestHandler<DeleteSocialRequestCommand>
    {
        private readonly ISocialRequestRepository repository;
        private readonly IMapper mapper;

        public DeleteSocialRequestCommandHandler(ISocialRequestRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteSocialRequestCommand request, CancellationToken cancellationToken)
        {
            var socialRequest = await repository.GetAsync(request.Id);
            await repository.DeleteAsync(socialRequest);

            return Unit.Value;
        }
    }
}
