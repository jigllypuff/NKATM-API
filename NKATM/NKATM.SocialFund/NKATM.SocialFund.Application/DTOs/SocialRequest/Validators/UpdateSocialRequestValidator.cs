using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialRequest.Validators
{
    public class UpdateSocialRequestValidator : AbstractValidator<UpdateSocialRequestDto>
    {
        public UpdateSocialRequestValidator()
        {
            Include(new ISocialRequestValidator());

            RuleFor(r => r.Comment)
              .MinimumLength(3).WithMessage("{PropertyName} must have at least 5 characters.")
              .MaximumLength(100).WithMessage("{PropertyName} must not exceed 200 characters.")
              .NotNull();
        }
    }
}
