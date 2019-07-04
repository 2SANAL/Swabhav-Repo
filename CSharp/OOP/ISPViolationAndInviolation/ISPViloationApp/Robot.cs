using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPViloationApp
{
    class Robot : IWorker
    {
        public void StartEat()
        {
            throw new NotImplementedException();
        }

        public void StartWork()
        {
            Console.WriteLine("Start Work Robot");
        }

        public void StopEat()
        {
            throw new NotImplementedException();
        }

        public void StopWork()
        {
            Console.WriteLine("End work RObot");
        }
    }
}
