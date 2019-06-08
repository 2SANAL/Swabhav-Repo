using System;


namespace BankingApplication
{
    class Program
    {
        static double withdrowamount, depositeamount;
        static int numberofaccount = 0;
        static int userchoice, accountnumber, typesaccount, usertransactionchoice;
        static double balance;
        static string name;
        static Account account;
        static Service service = new Service();
        static void Main(string[] args)
        {
            Service service = new Service();
            while (true)
            {

                if (numberofaccount == 0)
                {
                    Console.WriteLine("1.Add Account");
                    Console.WriteLine("2.Exit");
                    userchoice = Convert.ToInt32(Console.ReadLine());
                    if (userchoice == 1)
                    {
                        AddDetails();
                    }

                    if (userchoice == 2) break;
                    numberofaccount++;
                }
                if (numberofaccount > 0)
                {
                    Console.WriteLine("1.Add Account");
                    Console.WriteLine("2.Display Details");
                    Console.WriteLine("3.Exit");
                    userchoice = Convert.ToInt32(Console.ReadLine());
                    if (userchoice == 1)
                    {
                        AddDetails();
                    }

                    if (userchoice == 2)
                    {
                        service.DisplayAccountDetails(account);
                    }
                    if (userchoice == 3)
                    {
                        break;
                    }

                }
            }


        }
        public static void AddDetails()
        {

            Console.WriteLine("Enter Account Number");
            accountnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name");
            name = (Console.ReadLine());
            Console.WriteLine("Enter Balance ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choice Account Type 1.Saving Account \n 2. Current Account ");
            typesaccount = Convert.ToInt32(Console.ReadLine());

            if (typesaccount == 1)
            {
                account = new SavingAccount(accountnumber, name, balance);
                account.AccountType = "Saving Account";

                Console.WriteLine("1.Withdrow Balance");
                Console.WriteLine("2.Deposite Balance");
                Console.WriteLine("3.Details");
                Console.WriteLine("4.Exit");
                usertransactionchoice = Convert.ToInt32(Console.ReadLine());
                if (usertransactionchoice == 1)
                {
                    Console.WriteLine("Enter the Withdrow Amount");
                    withdrowamount = Convert.ToDouble(Console.ReadLine());
                    service.WithdrowAmount(account, withdrowamount);
                }
                if (usertransactionchoice == 2)
                {
                    Console.WriteLine("Enter the Deposite Amount");
                    depositeamount = Convert.ToDouble(Console.ReadLine());
                    service.DepositeAmount(account, depositeamount);

                }
                if (usertransactionchoice == 3)
                {
                    service.DisplayAccountDetails(account);
                }


            }
            if (typesaccount == 2)
            {
                account = new CurrentAccount(accountnumber, name, balance);
                account.AccountType = "Current Account";

                Console.WriteLine("1.Withdrow Balance");
                Console.WriteLine("2.Deposite Balance");
                Console.WriteLine("3.Details");
                Console.WriteLine("4.Exit");
                usertransactionchoice = Convert.ToInt32(Console.ReadLine());
                if (usertransactionchoice == 1)
                {
                    Console.WriteLine("Enter the Withdrow Amount");
                    withdrowamount = Convert.ToDouble(Console.ReadLine());
                    service.WithdrowAmount(account, withdrowamount);
                }
                if (usertransactionchoice == 2)
                {
                    Console.WriteLine("Enter the Deposite Amount");
                    depositeamount = Convert.ToDouble(Console.ReadLine());
                    service.DepositeAmount(account, depositeamount);

                }
                if (usertransactionchoice == 3)
                {
                    service.DisplayAccountDetails(account);
                }


            }
        }
    }
}

