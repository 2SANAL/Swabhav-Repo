using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatternDemoApp
{
    class Circule : IShape
    {
        private double _radius;

        public Circule(double radius)
        {
            _radius = radius;
        }


        public double AreaCalculator()
        {
            return (3.14 * _radius * _radius);
        }
    }
}
