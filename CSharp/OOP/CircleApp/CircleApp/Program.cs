using System;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // NewMethod();
            Console.WriteLine(new Circle().CalArea());
            printInfo(new Circle());

        }

        private static void NewMethod()
        {
            Circle small = new Circle();
            Circle big = new Circle();

            small.Redius = 2.2f;
            big.Redius = 10.5f;

            Circle temp = small;
            Console.WriteLine(temp.Redius);
            Console.WriteLine(small.Redius);
            temp.Redius = 1.1f;
            Console.WriteLine(temp.Redius);
            Console.WriteLine(small.Redius);
            printInfo(small);
            printInfo(big);

            
        }

        static void printInfo(Circle obj)
        {
            Console.WriteLine("Circle Redius " + obj.Redius + " and Area " + obj.CalArea());

        }
    }
}
