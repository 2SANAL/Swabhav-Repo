using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcLib
{
   public class NegiativeNumberException:Exception
    {
        public NegiativeNumberException(string message) : base(message)
        {

        }
    }
}
