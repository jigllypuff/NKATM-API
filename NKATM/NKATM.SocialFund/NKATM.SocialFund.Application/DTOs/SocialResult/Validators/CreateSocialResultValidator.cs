using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialResult.Validators
{
    public class CreateSocialResultValidator : AbstractValidator<CreateSocialResultDto>
    {
        public CreateSocialResultValidator()
        {
            RuleFor(r => r.NumberOfDays)
            .GreaterThanOrEqualTo(1).WithMessage("{PropertyName} must be greater or equal 1.");

            RuleFor(r => r.SocialTypeId)
                .NotEmpty().WithMessage("{PropertyName} does not exist.")
        }
    }
}
