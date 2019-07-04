using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountLib;
namespace AccountDelegatesAndEventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1234,"Akash",5000,8446997740,"akash@a.com");
            account.BalanceChangeEvent += SmsHandler;
            account.BalanceChangeEvent += EmailHandler;

            account.Deposite(100);
            account.Withdrowe(100);
        }
        private static void SmsHandler(Account account)
        {
            Console.WriteLine("SmS Notification");
            Console.WriteLine(account.Name+ " update balance is  " + account.Balance+"\n");
            
        }
        private static void EmailHandler(Account account)
        {
            Console.WriteLine("Email Notification");
            Console.WriteLine(account.Name + " update balance is  " + account.Balance + "\n");
        }
    }
}
