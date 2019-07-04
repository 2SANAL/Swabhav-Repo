using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPViloationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AtTheCafeteria(new Manager());
            AtTheWorkStation(new Manager());
            AtTheWorkStation(new Robot());
            AtTheCafeteria(new Robot());
        }
        private static void AtTheCafeteria(IWorker work)
        {
            Console.WriteLine("Inside Cafeteria");
            work.StartEat();
            work.StopEat();
        }
        private static void AtTheWorkStation(IWorker work)
        {
            Console.WriteLine("Inside WorkStation");
            work.StartWork();
            work.StopWork();
        }
    }
}
