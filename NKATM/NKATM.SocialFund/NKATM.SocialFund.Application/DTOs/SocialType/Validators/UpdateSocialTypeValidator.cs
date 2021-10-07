using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialType.Validators
{
    public class UpdateSocialTypeValidator : AbstractValidator<SocialTypeDto>
    {
        public UpdateSocialTypeValidator()
        {
            Include(new ISocialTypeValidator());

            RuleFor(r => r.Justification)
                .MinimumLength(3).WithMessage("{PropertyName} must have at least 5 characters.")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 200 characters.")
                .NotNull();

            RuleFor(r => r.Id).NotEmpty().WithMessage("Type of actual {PropertyName} is not existing.");
        }
    }
}
