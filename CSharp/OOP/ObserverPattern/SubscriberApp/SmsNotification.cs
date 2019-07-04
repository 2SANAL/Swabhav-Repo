using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace SubscriberApp
{
    class SmsNotification : IBalanceChangeNotification
    {
        public void Update(Account account)
        {
            Console.WriteLine("Number is :"+account.PhoneNumber+" Account Balance Update :"+account.Balance);
        }
    }
}
