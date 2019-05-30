using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAllingParentToChildConstApp
{
    class Child:Parent
    {
        public Child():base(12,12)
        {
            Console.WriteLine("Chlid constructor");
        }
        
        
    }
}
