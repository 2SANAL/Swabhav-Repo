
namespace BankingApplication
{
    class CurrentAccount:Account
    {
        

        public CurrentAccount(int accountnumber, string name, double balance) : base(accountnumber, name, balance)
        {

        }

        public override void withdrow(double withdrowamount)
        {
            
            Balance = Balance - withdrowamount;
           
        }

    }
}
