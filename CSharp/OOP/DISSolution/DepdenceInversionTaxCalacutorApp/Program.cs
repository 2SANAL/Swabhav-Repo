using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepdenceInversionTaxCalacutorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalaculator taxCalculator = new TaxCalaculator(LogType.DATABASE);
            Console.WriteLine("Result :"+taxCalculator.Calculator(0, 0));   
        }
    }
}
