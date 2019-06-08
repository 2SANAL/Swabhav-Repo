using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Vehical
{
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bike Move");
        }
    }
}
