using System;

namespace ArgumentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach(String s in args)
            {
                Console.WriteLine(s);
            }
        }
    }
}
