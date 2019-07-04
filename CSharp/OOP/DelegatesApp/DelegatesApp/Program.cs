using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DelegatesApp.Delegate1;

namespace DelegatesApp
{
   
    class Program

    {
        static void Main()

        {
            Delegate1 a = new Delegate1();
            MyDelegate m = new MyDelegate(a.Method1);
            m += a.Method2;
            m.Invoke();

        }

    }


}
