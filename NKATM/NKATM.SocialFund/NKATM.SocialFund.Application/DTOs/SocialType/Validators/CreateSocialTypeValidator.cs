using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialType.Validators
{
    public class CreateSocialTypeValidator : AbstractValidator<CreateSocialTypeDto>
    {
        public CreateSocialTypeValidator()
        {
            Include(new ISocialTypeValidator());
        }
    }
}
