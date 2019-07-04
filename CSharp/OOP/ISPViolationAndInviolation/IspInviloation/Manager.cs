using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspInviloation
{
    class Manager : IWorkEat
    {
        public void StartEat()
        {
            Console.WriteLine("Manager Start Eat ");
        }

        public void StartWork()
        {
            Console.WriteLine("Manager Start work ");
        }

        public void StopEat()
        {
            Console.WriteLine("Manager Stop Eat");
        }

        public void StopWork()
        {
            Console.WriteLine("Manager Stop work ");
        }
    }
}
