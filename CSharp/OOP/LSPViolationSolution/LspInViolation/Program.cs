using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspInViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Square square = new Square(10);
            Display(square);
            Display(rectangle);
            shuldNotChangeWidth(rectangle);
            shuldNotChangeWidth1(square);


        }
        private static void Display(IShapes shape)
        {
            Console.WriteLine("Area :"+shape.AreaCalaculation());
        }
        private static void shuldNotChangeWidth(IShapes shape)
        {
            int beforeChange = shape.GetWidth();
            shape.SetHight(0);
            int afterChange = shape.GetWidth();
            Console.WriteLine(beforeChange == afterChange); 
        }
        private static void shuldNotChangeWidth1(IShapes shape)
        {
            int beforeChange = 10;
            shape.SetHight(20);
            int afterChange = shape.GetWidth();
            Console.WriteLine(beforeChange == afterChange);
        }
    }
}
