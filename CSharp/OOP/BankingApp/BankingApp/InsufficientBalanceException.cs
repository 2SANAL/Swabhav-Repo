using System;


namespace BankingApp
{
    class InsufficientBalanceException:Exception
    {
        public InsufficientBalanceException(String message) : base(message)
        {

        }
    }
}
