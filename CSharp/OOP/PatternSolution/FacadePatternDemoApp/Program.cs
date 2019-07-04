using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathematicalOpertaion mathematicalOperation = new MathematicalOpertaion();

            double add = mathematicalOperation.Addition(12, 14);
            double multiplication = mathematicalOperation.Multiplication(12, 10);
            double power = mathematicalOperation.Power(2, 4);

            Console.WriteLine("Addtion :"+add);
            Console.WriteLine("Multiplication :" + multiplication);
            Console.WriteLine("power :" + power);
        }
    }
}
