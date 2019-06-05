using System;
using System.Configuration;

namespace AppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 =ConfigurationManager.AppSettings["k1"];
            string value2 = ConfigurationManager.AppSettings["k2"];
            string value3 = ConfigurationManager.AppSettings["k3"];
            Console.WriteLine(value1+" "+value2+" "+value3);

            


        }
    }
}
