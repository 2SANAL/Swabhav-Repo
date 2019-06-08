using System;


namespace BankingApplication
{
    class InsufficientBalanceException:Exception
    {
        public InsufficientBalanceException(String message) : base(message)
        {

        }
    }
}
