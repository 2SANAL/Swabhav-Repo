using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepdenceInversionTaxCalacutorApp
{
    class DataBaseLogger
    {
        public void Log(string errorMessage)
        {
            Console.WriteLine("DataBase Log");
            Console.WriteLine(errorMessage);
        }
    }
}
