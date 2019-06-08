using System;
using CalculateLib;

namespace CalculatorConsoleApp
{
    class Program
    {

        static double result;
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            result = calculate.Addition(25, 36);
            Console.WriteLine("Result " + result);

        }
    }
}
