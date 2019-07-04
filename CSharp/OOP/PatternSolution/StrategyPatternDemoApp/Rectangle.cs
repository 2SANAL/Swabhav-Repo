using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatternDemoApp
{
    class Rectangle : IShape
    {
        private double _hight, _width;

        public Rectangle(double hight, double width)
        {
            _hight = hight;
            _width = width;
        }

        public double AreaCalculator()
        {
            return _hight * _width;
        }
    }
}
