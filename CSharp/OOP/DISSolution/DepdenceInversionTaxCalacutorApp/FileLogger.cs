using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepdenceInversionTaxCalacutorApp
{
    class FileLogger
    {
        public void Log(string errorMessage)
        {
            Console.WriteLine("File Log");
            Console.WriteLine(errorMessage);
        }
    }
}
