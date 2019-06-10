using System;


namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            int c = a / b;
            Console.WriteLine("Result :" + c);
        }
    }
}
