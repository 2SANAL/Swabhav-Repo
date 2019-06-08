using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Vehical
{
    class Truk : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Truk Movable");
        }
    }
}
