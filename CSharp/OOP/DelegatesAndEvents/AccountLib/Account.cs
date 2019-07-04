using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountLib
{
    public delegate void DBalanceChange(Account account);

    public class Account
    {
        private readonly int _accountNumber;
        private readonly string _name;
        private double _balance;
        private readonly double _phoneNumber;
        private readonly string _emailAddress;
        public event DBalanceChange BalanceChangeEvent;

        public Account(int accountNumber, string name, double balance, double phoneNumber, string emailAddress)
        {
            _accountNumber = accountNumber;
            _name = name;
            _balance = balance;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;

        }

        public void Deposite(double amount)
        {
            _balance = _balance + amount;
            if (BalanceChangeEvent != null)
            {
                BalanceChangeEvent(this);
            }

        }
        public void Withdrowe(double amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Balance is less  to widthdrow");
            }
            else
            {
                _balance = _balance - amount;
                if (BalanceChangeEvent != null)
                {
                    BalanceChangeEvent(this);
                }
            }

        }



        public int AccountNumber
        {
            get { return _accountNumber; }
        }
        public string Name
        {
            get { return _name; }
        }
        public double Balance
        {
            get { return _balance; }
        }
        public double PhoneNumber
        {
            get { return _phoneNumber; }
        }
        public string EmailAddress
        {
            get { return _emailAddress; }
        }
    }
}
