using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialType.Validators;
using NKATM.SocialFund.Application.Exceptions;
using NKATM.SocialFund.Application.Features.SocialTypes.Commands;
using NKATM.SocialFund.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialTypes.Handlers.Commands
{
    public class UpdateSocialTypeCommandHandler : IRequestHandler<UpdateSocialTypeCommand, Unit>
    {
        private readonly ISocialTypeRepository repository;
        private readonly IMapper mapper;

        public UpdateSocialTypeCommandHandler(ISocialTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateSocialTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateSocialTypeValidator();
            var validatorResult = await validator.ValidateAsync(request.SocialTypeDto);

            if (validatorResult.IsValid == false)
                throw new ValidationException(validatorResult);

            var socialType = await repository.GetAsync(request.SocialTypeDto.Id);

            mapper.Map(request.SocialTypeDto, socialType);
            await repository.UpdateAsync(socialType);

            return Unit.Value;
        }
    }
}
