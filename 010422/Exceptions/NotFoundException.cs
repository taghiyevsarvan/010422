using System;
using System.Collections.Generic;
using System.Text;

namespace _010422.Exceptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
