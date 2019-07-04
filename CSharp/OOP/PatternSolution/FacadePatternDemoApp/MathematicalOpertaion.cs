using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePatternDemoApp
{
    class MathematicalOpertaion
    {
        private Addition _addition;
        private Power _power;
        private Multiplication _multiplication;

        public MathematicalOpertaion()
        {
            _addition = new Addition();
            _power = new Power();
            _multiplication = new Multiplication();
        }

        public double Addition(double number1,double number2)
        {
           return _addition.Operation(number1, number2);
        }
        public double Power(double number1, double number2)
        {
            return _power.Operation(number1, number2);
        }
        public double Multiplication(double number1, double number2)
        {
            return  _multiplication.Operation(number1, number2);
        }
    }
}
