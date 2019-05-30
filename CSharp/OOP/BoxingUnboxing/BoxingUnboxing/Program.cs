using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            Object obj = a;
            int b = (int)obj;
            Console.WriteLine(a);
            Console.WriteLine(obj);
            Console.WriteLine(b);
        }

    }
}
