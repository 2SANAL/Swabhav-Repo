using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "invoice1", 120, 0.28f, 0.18f);
            invoice.Print();
        }
    }
}
