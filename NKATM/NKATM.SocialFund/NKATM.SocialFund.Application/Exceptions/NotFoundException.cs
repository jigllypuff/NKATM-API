using System;
using System.Collections.Generic;
using System.Text;

namespace NKATM.SocialFund.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, Guid id) : base($"{name} with id {id} was not found.")
        {
        }
    }
}
