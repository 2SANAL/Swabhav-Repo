using System;

namespace EnumAPP
{
    class Program
    {
        enum Days {Sun,Mon=5,Tue,Wed,Thu,Fri,Sat };
        static void Main(string[] args)
        {
            int weekStart = (int)Days.Sun;
            int weekEnd = (int)Days.Tue;

            Console.WriteLine(Days.Mon);
            Console.WriteLine(Days.Sun);
            Console.WriteLine("Week Start "+weekStart);
            Console.WriteLine("Week End "+weekEnd);

            
        }
    }
}
