using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternApp
{
    interface IInvestor
    {
        void Update(Stock stock);
    }
}
