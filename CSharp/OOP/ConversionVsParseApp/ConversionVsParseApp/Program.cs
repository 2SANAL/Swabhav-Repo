using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversionVsParseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "12", b = "999999999999990", c = "10.2", d = null;
            int value = int.Parse(a);
            int result;
            //Console.WriteLine(value);
            //value = int.Parse(b);
            //Console.WriteLine(b);
            //value = int.Parse(c);
            //Console.WriteLine(value);
            //value = int.Parse(d);
            //Console.WriteLine(c);

            bool ifSuccess = int.TryParse(a, out result);
            Console.WriteLine(ifSuccess);
            ifSuccess = int.TryParse(b, out result);
            Console.WriteLine(ifSuccess);
            ifSuccess = int.TryParse(c, out result);
            Console.WriteLine(ifSuccess);
            ifSuccess = int.TryParse(d, out result);
            Console.WriteLine(ifSuccess);

            result = Convert.ToInt32(d);

        }
    }
}
