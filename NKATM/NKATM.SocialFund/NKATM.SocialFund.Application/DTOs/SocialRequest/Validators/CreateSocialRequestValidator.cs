using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.DTOs.SocialRequest.Validators
{
    public class CreateSocialRequestValidator : AbstractValidator<CreateSocialRequestDto>
    {
        public CreateSocialRequestValidator()
        {
            Include(new ISocialRequestValidator());
        }
    }
}
