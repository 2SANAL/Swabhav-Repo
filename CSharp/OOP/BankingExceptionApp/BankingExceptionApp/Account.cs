using BankingExceptionApp;
using System;
namespace BankingApplication
{
    class Account
    {
        private readonly int accountnumber;
        private readonly string name;
        private double balance;
        private readonly int _minimumAmount = 500;

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
        public void withdrow(double withdrowAmount)
        {


            if (balance < _minimumAmount || balance - withdrowAmount < 500)
            {
                throw new InsufficientFoundException(this, withdrowAmount);
            }
            balance = balance - withdrowAmount;
        }

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
            set
            {
                this.balance = value;
            }
        }


    }
}
