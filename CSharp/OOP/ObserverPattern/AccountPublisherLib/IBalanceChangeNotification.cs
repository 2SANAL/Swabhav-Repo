using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPublisherLib
{
  public  interface IBalanceChangeNotification
    {
        void Update(Account account);
    }
}
