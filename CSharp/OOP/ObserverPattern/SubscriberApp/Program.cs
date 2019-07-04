using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;
namespace SubscriberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1234, "Akash", 1000, 8446997740, "AkashJaiswal@g.com");
            account.Subcribe(new EmailNotification());
            account.Subcribe(new SmsNotification());
            account.Deposite(100);
       


        }
    }
}
