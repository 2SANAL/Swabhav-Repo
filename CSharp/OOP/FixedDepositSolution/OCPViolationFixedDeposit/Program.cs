using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPViolationFixedDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedDeposit = new FixedDeposit("akash", 1230, 2, FestivalType.NORMAL);

            Console.WriteLine("Name :"+fixedDeposit.Name);
            Console.WriteLine("Principle  :" + fixedDeposit.Principle);
            Console.WriteLine("Year:" + fixedDeposit.Year);
            Console.WriteLine("Festival Name :" + fixedDeposit.FestivalName);

            Console.WriteLine("Simple Intrest :"+fixedDeposit.CalaculateSimpleInterest());

        }
    }
}
