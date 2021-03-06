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
            Include(new ISocialResultValidator());
        }
    }
}
