using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Vehical
{
    class Bika : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car Move");
        }
    }
}
