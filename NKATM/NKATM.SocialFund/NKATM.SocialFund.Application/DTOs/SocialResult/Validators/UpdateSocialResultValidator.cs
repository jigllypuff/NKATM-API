using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialResult.Validators
{
    public class UpdateSocialResultValidator : AbstractValidator<UpdateSocialResultDto>
    {
        public UpdateSocialResultValidator()
        {
            Include(new ISocialResultValidator());
        }
    }
}
