using System;

namespace TimeBeforeAndAftorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            AccountProxy accountProxy = new AccountProxy(123, "akash", 5000, 8446997740, "akash@a.com");

            accountProxy.Deposite(1000);
            accountProxy.Withdrow(500);

        }
    }
}
