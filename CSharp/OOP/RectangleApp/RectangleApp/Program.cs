using System;

namespace RectangleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            /* Rectangle small = new Rectangle();
             small.height = 10;
             small.width = 5;
             Rectangle big = new Rectangle();
             big.height = 100;
             big.width = 20;
             Console.WriteLine("Height " + small.height + " Weight " + small.width);
                 Console.WriteLine("Small rectangle Area is " + small.CalculationArea());
                 Console.WriteLine("Height " + big.height + "Weight " + big.width);
                 Console.WriteLine("Big rectangle Area  " + big.CalculationArea());    */
            Rectangle[] rec = new Rectangle[3];
            rec[0] = new Rectangle();
            rec[1] = new Rectangle();
            rec[2] = new Rectangle();
            rec[0].width = 10;
            rec[0].height = 5;
            rec[1].width = 20;
            rec[1].height = 10;
            rec[2].width = 50;
            rec[2].height = 5;
            int sum = rec[0].CalculationArea() + rec[1].CalculationArea() + rec[2].CalculationArea();
            Console.WriteLine("Rectangle 1 hight "+rec[0].height+" width "+rec[0].width+ " Rectangle Area "+rec[0].CalculationArea());
            Console.WriteLine("Rectangle 2 hight " + rec[1].height + " width " + rec[1].width + " Rectangle Area " + rec[1].CalculationArea());
            Console.WriteLine("Rectangle 3 hight " + rec[2].height + " width " + rec[2].width + " Rectangle Area " + rec[2].CalculationArea());

            Console.WriteLine("Sum of Area"+sum);
        }
    }
}
