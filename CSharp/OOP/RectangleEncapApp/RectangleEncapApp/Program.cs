using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            small.SetHeight(-5);
            small.SetWidth(10);
            Rectangle Big = new Rectangle();
            Big.SetWidth(101);
            Big.SetHeight(20);

            Console.WriteLine("Small Rectangle Hight "+ small.GetHight()+ " Small Rectangle width " + small.GetWidth()+ " Area of Small "+small.CalculateArea());
            Console.WriteLine("Big Rectangle Hight " + Big.GetHight() + " Big Rectangle width " + Big.GetWidth() + " Area of Big " + Big.CalculateArea());

        }
    }
}
