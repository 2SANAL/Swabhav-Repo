using System;

using BankingApplication;

namespace BankingExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account(1234, " Dhruv ", 2500);
                account.withdrow(2220);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
