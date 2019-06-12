using BankingApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingExceptionApp
{
    class InsufficientFoundException : Exception
    {
        private readonly Account _account;
        private readonly double _withroamount;

        public InsufficientFoundException(Account account, double withroamount)
        {
            _account = account;
            _withroamount = withroamount;
        }
        public override string Message
        {
            get
            {
                return _account.Name + " in your Account not sufficient Balance to withdrow :"
                    + _withroamount + " In your Account balance is :" + _account.Balance+
                    "Please maintent minimum 500 Balance in your account ";
            }
        }
    }
}
