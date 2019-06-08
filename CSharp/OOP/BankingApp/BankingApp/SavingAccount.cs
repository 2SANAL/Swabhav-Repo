using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp
{
    class SavingAccount : Account
    {
        private double _savingaccountbalance;
        public SavingAccount(int accountnumber, string name, double balance) : base(accountnumber, name, balance)
        {

        }

        public override void withdrow(double withdrowamount)
        {
            _savingaccountbalance = Balance;
            if (_savingaccountbalance < 500 || _savingaccountbalance - withdrowamount < 500)
            {
                throw new InsufficientBalanceException("Balance is insufficient to withdrow");
            }

            _savingaccountbalance = _savingaccountbalance - withdrowamount;
        }
           
    }
}
