using System;

namespace oef17_6
{
    public class InvalidEmailException : ApplicationException
    {
        public InvalidEmailException(string message) : base(message)
        {
        }
    }
}