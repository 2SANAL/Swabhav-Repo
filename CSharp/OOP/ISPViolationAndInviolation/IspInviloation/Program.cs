using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspInviloation
{
    class Program
    {
        static void Main(string[] args)
        {
            AtTheCafeteria(new Manager());
            AtTheWorkStation(new Manager());
            AtTheWorkStation(new Robot());
          //  AtTheCafeteria(new Robot());
        }
        private static void AtTheCafeteria(IEat eat)
        {
            Console.WriteLine("Inside Cafeteria");
            eat.StartEat();
            eat.StopEat();
        }
        private static void AtTheWorkStation(IWork work)
        {
            Console.WriteLine("Inside the WorkStation");
            work.StartWork();
            work.StopWork();
        }
    }
}
