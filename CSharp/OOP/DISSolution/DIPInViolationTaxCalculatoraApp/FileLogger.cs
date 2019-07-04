using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPInViolationTaxCalculatoraApp
{
    class FileLogger : ILog
    {
        public void Log(string errorMessage)
        {
            Console.WriteLine("File Logger");
            Console.WriteLine(errorMessage);
        }
    }
}
