

namespace BankingApp
{
    class CurrentAccount:Account
    {
        private double _currentaccountbalance;

        public CurrentAccount(int accountnumber, string name, double balance) : base(accountnumber, name, balance)
        {

        }

        public override void withdrow(double withdrowamount)
        {
            _currentaccountbalance = Balance;
            _currentaccountbalance = _currentaccountbalance - withdrowamount;
        }

    }
}
