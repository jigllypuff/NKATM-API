using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialRequest.Validators
{
    public class ISocialRequestValidator : AbstractValidator<ISocialRequestDto>
    {
        public ISocialRequestValidator()
        {
            RuleFor(r => r.StartDate)
               .LessThan(DateTime.Now).WithMessage("{PropertyName} cannot be earlier than {ComparisonValue}");

            RuleFor(r => r.SocialTypeId)
                .NotEmpty().WithMessage("{PropertyName} does not exist.");
        }
    }
}
