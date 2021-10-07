using AutoMapper;
using MediatR;
using NKATM.SocialFund.Application.DTOs.SocialType.Validators;
using NKATM.SocialFund.Application.Exceptions;
using NKATM.SocialFund.Application.Features.SocialTypes.Commands;
using NKATM.SocialFund.Application.Persistance.Contracts;
using NKATM.SocialFund.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Features.SocialTypes.Handlers.Commands
{
    public class CreateSocialTypeCommandHandler : IRequestHandler<CreateSocialTypeCommand, Guid>
    {
        private readonly ISocialTypeRepository repository;
        private readonly IMapper mapper;

        public CreateSocialTypeCommandHandler(ISocialTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Guid> Handle(CreateSocialTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateSocialTypeValidator();
            var validatorResult = await validator.ValidateAsync(request.SocialTypeDto);

            if (validatorResult.IsValid == false)
                throw new ValidationException(validatorResult);

            var socialType = mapper.Map<SocialType>(request.SocialTypeDto);

            socialType = await repository.AddAsync(socialType);

            return socialType.Id;
        }
    }
}
