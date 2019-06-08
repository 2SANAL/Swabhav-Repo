using System;


namespace BankingApplication
{
    class Service
    {
        

        public  void DepositeAmount(Account account,double depositeamount)
        {
            account.Deposite(depositeamount);
            Console.WriteLine("Balance " + account.Balance);
        }
        public  void WithdrowAmount(Account account, double withdrowamount)
        {
            account.withdrow(withdrowamount);
            Console.WriteLine("Balance " + account.Balance);
        }
        public  void DisplayAccountDetails(Account account)
        {
            Console.WriteLine("Account holder Details ");
            Console.WriteLine(" Name : " + account.Name);
            Console.WriteLine(" Account Number : " + account.AccountNumber);
            Console.WriteLine(" Balance : " + account.Balance);
            Console.WriteLine("Account Type :"+account.AccountType);
        }
        

    }
}
