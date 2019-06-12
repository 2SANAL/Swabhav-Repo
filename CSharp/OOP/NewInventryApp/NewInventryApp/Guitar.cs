using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewInventryApp
{
    class Guitar : Instrument
    {


        public Guitar(string serialno, double price, GuitarSpec spec) : base(serialno, price, spec)
        {

        }


    }
}
