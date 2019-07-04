using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPublisherLib
{
    public delegate void DBalanceChange(Account account);

    public class Account
    {
        private readonly int _accountNumber;
        private readonly string _name;
        private double _balance;
        private readonly double _phoneNumber;
        private readonly string _emailAddress;
        private List<IBalanceChangeNotification> _subcriberlist=new List<IBalanceChangeNotification>();

        public Account(int accountNumber, string name, double balance, double phoneNumber, string emailAddress)
        {
            _accountNumber = accountNumber;
            _name = name;
            _balance = balance;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;

        }



        public void Withdraw(double amount)
        {
            if ((Balance < 500) && (Balance - amount) < 500)
                return;
            _balance -= amount;
            Notify();
        }

        public void Deposite(double amount)
        {
            _balance += amount;
            Notify();
        }

        public void Subcribe(IBalanceChangeNotification subcriber)
        {
            _subcriberlist.Add(subcriber);
        }

        public void UnSubcribe(IBalanceChangeNotification subcriber)
        {
            _subcriberlist.Remove(subcriber);
        }

        public void Notify()
        {
            foreach (IBalanceChangeNotification subcriber in _subcriberlist)
                subcriber.Update(this);
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
