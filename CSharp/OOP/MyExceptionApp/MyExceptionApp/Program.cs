using System;

namespace MyExceptionApp
{
    class Program
    {
        static void validate(int age)
        {
            if(age < 18)
            {
                throw new InvalidAgeException("Sorry ,Age must be greater than 18");
            }
            Console.WriteLine("Age "+age);
        }
        static void Main(string[] args)
        {
            try
            {
                validate(12);
            }
            catch (InvalidAgeException e) { Console.WriteLine(e); }
        }
    }
}
