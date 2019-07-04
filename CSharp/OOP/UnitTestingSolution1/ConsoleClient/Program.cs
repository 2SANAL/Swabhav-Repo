using System;

using CalcLib;
namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.CubeOfEvenNumber(2);
            Console.WriteLine(result);
        }
    }
}
