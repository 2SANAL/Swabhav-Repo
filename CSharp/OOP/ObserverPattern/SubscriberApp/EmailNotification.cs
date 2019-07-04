using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace SubscriberApp
{
    class EmailNotification : IBalanceChangeNotification
    {
        public void Update(Account account)
        {
            Console.WriteLine("Email Id :"+account.EmailAddress+" Account Balance is Update :"+account.Balance);
        }
    }
}
