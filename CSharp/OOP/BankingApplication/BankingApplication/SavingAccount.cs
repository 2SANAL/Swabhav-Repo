
namespace BankingApplication
{
    class SavingAccount:Account
    {
  
        public SavingAccount(int accountnumber, string name, double balance) : base(accountnumber, name, balance)
        {
        }

        public override void withdrow(double withdrowamount)
        {
          
            if (Balance == 500 || Balance - withdrowamount < 500)
            {
                throw new InsufficientBalanceException("Balance is insufficient to withdrow");
            }
            Balance = Balance - withdrowamount;
            
        }
    }
}

