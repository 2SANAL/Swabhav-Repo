using System;

namespace ConstructorApp
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Default constructor");
        }
        public Program(int a, int b)
        {
            Console.WriteLine("Parameter Constructor");
            Console.WriteLine(a + " " + b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program p1 = new Program(10, 20);

        }
    }
}
