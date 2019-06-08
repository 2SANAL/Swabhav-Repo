using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{
    abstract class Account
    {
        protected int accountnumber;
        protected string name;
        protected double balance;

        public Account() { }

        public Account(int accountnumber, string name, double balance)
        {
            this.accountnumber = accountnumber;
            this.balance = balance;
            this.name = name;
        }
        public void Deposite(double depositamount)
        {
            balance = balance + depositamount;
        }
        abstract public void withdrow(double withdrowamount);
      
        public string Name
        {
            get { return name; }
        }
        public int AccountNumber
        {
            get { return accountnumber; }
        }
        public double Balance
        {
            get { return balance; }
        }

    }
}
