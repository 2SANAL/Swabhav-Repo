using System;


namespace BankingApp
{
    class Program
    {
        static double withdrowamount, depositeamount;
        static void Main(string[] args)
        {

            while (true)
            {
                int userchoice, accountnumber, typesaccount, usertransactionchoice;
                double balance;
                string name;
                Account account;

                Console.WriteLine("1.Account Details");
                Console.WriteLine("2.Exit");
                userchoice = Convert.ToInt32(Console.ReadLine());

                if (userchoice == 1)
                {
                    Console.WriteLine("Enter Account Number");
                    accountnumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Account Holder Name");
                    name = (Console.ReadLine());
                    Console.WriteLine("Enter Balance ");
                    balance = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choice Account Type 1.Saving Account 2. Current Account ");
                    typesaccount = Convert.ToInt32(Console.ReadLine());
                    if (typesaccount == 1)
                    {
                        account = new SavingAccount(accountnumber, name, balance);

                        Console.WriteLine("1.Withdrow Balance");
                        Console.WriteLine("2.Deposite Balance");
                        Console.WriteLine("3.Exit");
                        usertransactionchoice = Convert.ToInt32(Console.ReadLine());
                        if (usertransactionchoice == 1)
                        {
                            WithdrowAmount(account);
                        }
                        if (usertransactionchoice == 2)
                        {
                            DepositeAmount(account);
                        }
                        if (usertransactionchoice == 3)
                        {
                            break;
                        }
                        
                    }
                    if (typesaccount == 2)
                    {
                        account = new CurrentAccount(accountnumber, name, balance);
                        Console.WriteLine("1.Withdrow Balance");
                        Console.WriteLine("2.Deposite Balance");
                        Console.WriteLine("3.Exit");
                        usertransactionchoice = Convert.ToInt32(Console.ReadLine());
                        if (usertransactionchoice == 1)
                        {
                            WithdrowAmount(account);
                        }
                        if (usertransactionchoice == 2)
                        {
                            DepositeAmount(account);
                        }
                        if (usertransactionchoice == 3)
                        {
                            break;
                        }
                    }


                }
                if (userchoice == 2)
                {
                    break;
                }

            }
        }
        public static void DepositeAmount(Account account)
        {

            Console.WriteLine("Enter the Deposite Amount");
            depositeamount = Convert.ToDouble(Console.ReadLine());
            account.withdrow(depositeamount);
            Console.WriteLine("Balance " + account.Balance);
        }
        public static void WithdrowAmount(Account account)
        {
            Console.WriteLine("Enter the Withdrow Amount");
            withdrowamount = Convert.ToDouble(Console.ReadLine());
            account.withdrow(withdrowamount);
            Console.WriteLine("Balance " + account.Balance);
        }
    }
}
