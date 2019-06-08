using System;


namespace CalculateLib
{
    class InvalidNumberException : Exception
    {
        public InvalidNumberException(String message) : base(message)
        {
        }
    }
}
