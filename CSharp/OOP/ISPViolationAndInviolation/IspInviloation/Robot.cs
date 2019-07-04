using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspInviloation
{
    class Robot : IWork
    {
        public void StartWork()
        {

            Console.WriteLine("Robot Start work ");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot Stop work ");
        }
    }
}
