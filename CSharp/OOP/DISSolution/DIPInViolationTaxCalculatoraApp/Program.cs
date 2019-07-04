using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPInViolationTaxCalculatoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalaculator taxCalaculator = new TaxCalaculator(new DataBaseLogger());
            Console.WriteLine("Result "+taxCalaculator.Calaculator(0, 0));
            TaxCalaculator taxCalaculator1 = new TaxCalaculator(new FileLogger());
            Console.WriteLine("Result " + taxCalaculator.Calaculator(0, 0));
        }
    }
}
