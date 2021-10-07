using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> ValidationErrors { get; set; } = new List<string>();

        public ValidationException(ValidationResult validationResult)
        {
            foreach (var item in validationResult.Errors)
            {
                ValidationErrors.Add(item.ErrorMessage);
            }
        }
    }
}
