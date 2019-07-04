using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib
{
    class Audi : IAutoMobile
    {
        
        public void Start()
        {
            Console.WriteLine("Start Audi");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Audi");
        }

       
    }


}
