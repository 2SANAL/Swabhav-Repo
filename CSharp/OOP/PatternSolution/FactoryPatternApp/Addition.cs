using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternApp
{
    class Addition : IMathoperation
    {
        public double Operation(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
