using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.Features.SocialRequests.Commands;
using NKATM.SocialFund.Application.Persistance.Contracts;
using NKATM.SocialFund.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialRequests.Handlers.Commands
{
    public class CreateSocialRequestCommandHandler : IRequestHandler<CreateSocialRequestCommand, Guid>
    {
        private readonly ISocialRequestRepository repository;
        private readonly IMapper mapper;

        public CreateSocialRequestCommandHandler(ISocialRequestRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<Guid> Handle(CreateSocialRequestCommand request, CancellationToken cancellationToken)
        {
            var socialRequest = mapper.Map<SocialRequest>(request.SocialRequestDto);
            socialRequest = await repository.AddAsync(socialRequest);
            return socialRequest.Id;
        }
    }
}
