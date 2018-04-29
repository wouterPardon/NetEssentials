using System;

namespace Oefening17_7
{
    public class WrongSaldoException : ApplicationException
    {
        public WrongSaldoException(string message) : base(message)
        {

        }
    }
}