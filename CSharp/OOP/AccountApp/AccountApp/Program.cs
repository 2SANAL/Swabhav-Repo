using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Account Details");
            Business.Account account1 = new Business.Account(123, "Akash", 5000);
            DisplayInfo(account1);
            Business.Account account2 = new Business.Account(124, "Dhruv");
            DisplayInfo(account1);
            Business.Account account3 = new Business.Account(125, "Dipesh",2560);

            DisplayInfo(account1);

            Console.WriteLine("deposite Balance");
            account1.deposit(3600);
            DisplayInfo(account1);
            account2.deposit(2550);
            DisplayInfo(account2);
            Console.WriteLine("withdrow Balance");
            account1.withdrow(3600);
            DisplayInfo(account1);
            account2.withdrow(3550);

            DisplayInfo(account2);


            Business.Account account = new Business.Account();
            Business.Account account4 = new Business.Account();

        }
        public static void DisplayInfo(Business.Account obj)
        {
            Console.WriteLine("Number of Object create  "+obj.Counter);
            Console.WriteLine("\nName " + obj.Name + " Account Number " + obj.Accno + " Balance " + obj.Balance);

        }

    }
}
