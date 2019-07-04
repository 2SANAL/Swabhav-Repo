using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib
{
    class BMW : IAutoMobile
    {
       
        public void Start()
        {
            Console.WriteLine("Start BWM");
        }

        public void Stop()
        {
            Console.WriteLine("Stop BWM");
        }

      
    }
}
