
namespace BankingApplication
{
    abstract class Account
    {
        protected int accountnumber;
        protected string name;
        protected double balance;
        protected string accounttype;

        public Account() { }

        public Account(int accountnumber, string name, double balance)
        {
            this.accountnumber = accountnumber;
            this.balance = balance;
            this.name = name;
        }
        public void Deposite(double depositamount)
        {
            balance = balance + depositamount;
        }
        public abstract void withdrow(double withdrowamount);

        public string Name
        {
            get { return name; }
        }
        public int AccountNumber
        {
            get { return accountnumber; }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                this.balance = value;
            }
        }
        public string AccountType
        {
            get
            {
                return accounttype;
            }
            set
            {
                accounttype = value;
            }
        }
    }
}
