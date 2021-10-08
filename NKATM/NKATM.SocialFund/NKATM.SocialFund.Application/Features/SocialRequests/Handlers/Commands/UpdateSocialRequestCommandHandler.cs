using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialRequest.Validators;
using NKATM.SocialFund.Application.Exceptions;
using NKATM.SocialFund.Application.Features.SocialRequests.Commands;
using NKATM.SocialFund.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialRequests.Handlers.Commands
{
    public class UpdateSocialRequestCommandHandler : IRequestHandler<UpdateSocialRequestCommand, Unit>
    {
        private readonly ISocialRequestRepository repository;
        private readonly IMapper mapper;

        public UpdateSocialRequestCommandHandler(ISocialRequestRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateSocialRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateSocialRequestValidator();
            var validatorResult = await validator.ValidateAsync(request.SocialRequestDto);

            if (validatorResult.IsValid == false)
                throw new ValidationException(validatorResult);

            var socialRequest = await repository.GetAsync(request.Id);

            if (request.SocialRequestDto != null)
            {
                mapper.Map(request.SocialRequestDto, socialRequest);
                await repository.UpdateAsync(socialRequest);
            }
            else if(request.ChangeSocialRequestStatusDto != null)
            {
                await repository.ChangeSocialRequestStatus(socialRequest, request.ChangeSocialRequestStatusDto.Approved);
            }

            return Unit.Value;
        }
    }
}
