using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcLib
{
    public class Calculator
    {
        public int CubeOfEvenNumber(int number)
        {
            
                if (number % 2 == 0)
                {
                    return (number * number * number);
                }
            if(number % 2 != 0)
            {
                throw new OddNumberException("Odd Number Found");
            }
            throw new NegiativeNumberException("Number is Negiative");
          
        }
    }
}
