using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialResult.Validators
{
    public class ISocialResultValidator : AbstractValidator<ISocialResultDto>
    {
        public ISocialResultValidator()
        {
            RuleFor(r => r.Days)
          .GreaterThanOrEqualTo(1).WithMessage("{PropertyName} must be greater or equal 1.");

            RuleFor(r => r.SocialTypeId)
                .NotEmpty().WithMessage("{PropertyName} does not exist.");
        }
    }
}
