using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperationFactory mathoperation = new MathOperationFactory();

            IMathoperation operation1 = mathoperation.GetOperation("ADDITION");
            double add = operation1.Operation(10, 20);

            IMathoperation operation2 = mathoperation.GetOperation("POWER");
            double power = operation2.Operation(10, 3);

            Console.WriteLine("Addition :" + add);
            Console.WriteLine("Power :" + power);
        }
    }
}
