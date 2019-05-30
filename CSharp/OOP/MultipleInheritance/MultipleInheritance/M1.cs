using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace MultipleInheritance
{
    interface a
    {
        void lang();
    } 
    class M1:a
    {
      public void lang()
        {
            Console.WriteLine("lang");
        }

    }
    interface b
    {
        void sub();
    }
    class m2: b
    {
        public void sub()
        {
            Console.WriteLine("m2 b");
        }

    }
    class m3 : a,b
    {
        M1 m1 = new M1();
        m2 m2 = new m2();
        public void lang()
        {
            m1.lang();
        }
        public void sub()
        {
            m2.sub();
        }
    }
}
