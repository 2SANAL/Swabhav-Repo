using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OcrOcrInViolationFixedDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedDepositHoli = new FixedDeposit("akash", 1230, 2, new Holi());
            FixedDeposit fixedDepositNormal = new FixedDeposit("akash", 1230, 2, new Normal());
            FixedDeposit fixedDepositNewYear = new FixedDeposit("akash", 1230, 2, new NewYear());

            Display(fixedDepositHoli);
            Display(fixedDepositNormal);
            Display(fixedDepositNewYear);
        }
        public static void Display(FixedDeposit fixedDeposit)
        {
            Console.WriteLine("Name :" + fixedDeposit.Name);
            Console.WriteLine("Principle  :" + fixedDeposit.Principle);
            Console.WriteLine("Year:" + fixedDeposit.Year);
            Console.WriteLine("Festival Name :" + fixedDeposit.FestivalName);

            Console.WriteLine("Simple Intrest :" + fixedDeposit.CalaculateSimpleInterest());
            Console.WriteLine("\n");
        }
    }
}
