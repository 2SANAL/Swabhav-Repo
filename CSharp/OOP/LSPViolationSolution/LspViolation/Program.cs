using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle reactangle = new Rectangle(10, 12);
            
            Square square = new Square(10);
            
            Should_Not_Change_Width_WhenHightChange(reactangle);
            Should_Not_Change_Width_WhenHightChanges(square);
        }

        public static void Should_Not_Change_Width_WhenHightChange(Rectangle reactangle)
        {
            int widthBeforeChange = reactangle.GetWidth();
            reactangle.SetHight(100);
            int Afterwidth = reactangle.GetWidth();
            Console.WriteLine(widthBeforeChange==Afterwidth);
        }
        public static void Should_Not_Change_Width_WhenHightChanges(Square square)
        {
            int widthBeforeChange = square.GetWidth();
            square.SetHight(100);
            int Afterwidth = square.GetWidth();
            Console.WriteLine(widthBeforeChange == Afterwidth);
        }


    }
}
