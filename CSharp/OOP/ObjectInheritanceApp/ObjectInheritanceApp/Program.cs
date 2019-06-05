using System;
using AccountApp.Business;

namespace ObjectInheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(10, "Abc", 20000);
            Console.WriteLine(account1);
            Console.WriteLine("\n");
            Console.WriteLine(account1.ToString());
        }
    }
}
