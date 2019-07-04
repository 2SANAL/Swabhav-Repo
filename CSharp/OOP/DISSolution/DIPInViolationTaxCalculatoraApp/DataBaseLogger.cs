using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPInViolationTaxCalculatoraApp
{
    class DataBaseLogger : ILog
    {
        public void Log(string errorMessage)
        {
            Console.WriteLine("DataBase Logger");
            Console.WriteLine(errorMessage);
        }
    }
}
