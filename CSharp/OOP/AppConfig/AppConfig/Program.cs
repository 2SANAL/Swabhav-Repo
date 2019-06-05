using System;
using System.Reflection;

namespace AppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = System.Configuration.ConfigurationManager.AppSettings["k1"];
            string value2 = System.Configuration.ConfigurationManager.AppSettings["k2"];
            string value3 = System.Configuration.ConfigurationManager.AppSettings["k3"];
            Console.WriteLine(value1+" "+value2+" "+value3);

            Type type = Type.GetType("AccountApp.Business.account");

            PropertyInfo[] properties = type.GetProperties();
            foreach(PropertyInfo proprty in properties)
            {
                Console.WriteLine(proprty.Name);
            }


        }
    }
}
