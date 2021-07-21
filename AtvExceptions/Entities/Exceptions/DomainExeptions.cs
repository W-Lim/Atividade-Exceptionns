using System;
using System.Collections.Generic;
using System.Text;

namespace AtvExceptions.Entities.Exceptions
{
    class DomainExeptions : ApplicationException
    {
        public DomainExeptions(string message) : base(message)
        {

        }
    }
}
