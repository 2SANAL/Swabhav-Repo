using System;
using AccountApp.Business;

namespace ObjectInheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(10, "Abc", 20000);
           
            Console.WriteLine("\n");
            Console.WriteLine(account1.ToString());
            Console.WriteLine(" \n");

            Account account2 = new Account(10, "Abc", 20000);
            Console.WriteLine(account1.GetHashCode());
            Console.WriteLine(account2.GetHashCode());

            Console.WriteLine(account1 == account1);
            Console.WriteLine(account1 == account2);
            Console.WriteLine(account1.Equals(account1));
            Console.WriteLine(account1.Equals(account2));

        }
    }
}
