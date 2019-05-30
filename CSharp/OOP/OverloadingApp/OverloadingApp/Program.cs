using System;

namespace OverloadingApp
{
    class Program
    {
        static void printInfo(int a)
        {
            Console.WriteLine("Overload 1 ");
            Console.WriteLine("val of a " + a);
        }
        static void printInfo(float a)
        {
            Console.WriteLine("Overload 2 ");
            Console.WriteLine("val of a " + a);
        }
        static void printInfo(double a)
        {
            Console.WriteLine("Overload 1 ");
            Console.WriteLine("val of a " + a);
        }
        static void printInfo(char a)
        {
            Console.WriteLine("Overload 1 ");
            Console.WriteLine("val of a " + a);
        }

        static void Main(string[] args)
        {
            printInfo(12f);
            printInfo(222);
            printInfo(23.11);
            printInfo('A');
        }
    }
}
