using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib
{
    class Tesla : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Start Tesla");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Tesla");
        }
    }
}
