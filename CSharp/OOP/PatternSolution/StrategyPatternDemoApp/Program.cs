using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Circule circule = new Circule(12.2);
            DisplayArea(rectangle);
            DisplayArea(circule);

        }
        private static void DisplayArea(IShape shape)
        {
            Console.WriteLine("Area :" + shape.AreaCalculator());
        }
    }
}
