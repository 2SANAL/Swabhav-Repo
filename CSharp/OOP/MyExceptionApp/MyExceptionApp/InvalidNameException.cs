using System;


namespace MyExceptionApp
{
    class InvalidNameException:Exception
    {
        public InvalidNameException(String message):base(message)
        {
        }
    }
}
