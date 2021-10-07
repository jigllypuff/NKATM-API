using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialType.Validators
{
    public class ISocialTypeValidator : AbstractValidator<ISocialTypeDto>
    {
        public ISocialTypeValidator()
        {
            RuleFor(r => r.Name)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .MinimumLength(5).WithMessage("{PropertyName} must have at least 5 characters.")
               .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.")
               .NotNull();

            RuleFor(r => r.Days).NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThanOrEqualTo(1).WithMessage("{PropertyName} must be equal or greater than 1.");
        }
    }
}
