using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternApp
{
    class Power : IMathoperation
    {
        public double Operation(double number1, double number2)
        {
            double result = number1;

            for (double i = number2; i > 1; i--)
            {
                result = number1 * result;
            }
            return result;
        }
    }
}
