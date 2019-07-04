using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddaperForDqueeAndEquee
{
    interface IQueue<T>:IEnumerable<T>

    {
        void Enquee(T element);
        T Dequee();
        int Count();
    }
}
