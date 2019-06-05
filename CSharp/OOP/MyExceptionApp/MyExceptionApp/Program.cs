using System;

namespace MyExceptionApp
{
    class Program
    {
        static void validate(string name)
        {
            if(!name .Equals("sanal") )
            {
                throw new InvalidNameException("Sorry ,name not is sanal");
            }
            Console.WriteLine("Name "+name);
        }
        static void Main(string[] args)
        {
            try
            {
                validate("dhruv");
            }
            catch (InvalidNameException e) { Console.WriteLine(e); }
        }
    }
}
