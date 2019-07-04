using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace TimeBeforeAndAftorApp
{
    class AccountProxy
    {
        private Account _account;


        public AccountProxy(int accountNumber, string name, double balance, double phoneNumber, string email)
        {
            _account = new Account(accountNumber, name, balance, phoneNumber, email);
        }

        public void Deposite(double amount)
        {

            var berforeCallDeposite = System.Diagnostics.Stopwatch.StartNew();

            berforeCallDeposite.Start();
            Console.WriteLine($"Start Time: {berforeCallDeposite.ElapsedMilliseconds} ms");
            _account.Deposite(amount);
            Console.WriteLine("Balance:" + _account.Balance);
            berforeCallDeposite.Stop();
            Console.WriteLine($"End Time: {berforeCallDeposite.ElapsedMilliseconds} ms");
          
        }

        public void Withdrow(double amount)
        {

            Console.WriteLine();
            Console.WriteLine(DateTime.Now);
            _account.Withdraw(amount);
            Console.WriteLine("Balance:" + _account.Balance);
            Console.WriteLine(DateTime.Now);

        }


    }
}
