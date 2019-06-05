using System;


namespace MyExceptionApp
{
    class InvalidAgeException:Exception
    {
        public InvalidAgeException(String message):base(message)
        {
        }
    }
}
