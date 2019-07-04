using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewInventryApp
{
    class GuitarSpec 
    {

        private int _numstring;


        public GuitarSpec(Builder builder, string model, Type type, int numstring, Wood backwood,
            Wood topwood) 
        {
            _numstring = numstring;
        }

        public int Getnumstring() { return _numstring; }

        //public bool matches(InstrumentSpec otherspec)
        //{
        //    if (!base.matches(otherspec))
        //    {
        //        return false;
        //    }
        //    if (!(otherspec is GuitarSpec))
        //    {
        //        return false;
        //    }
        //    GuitarSpec spec = (GuitarSpec)otherspec;
        //    if (_numstring != spec.Getnumstring())
        //        return false;

        //    return true;
        //}
    }
}
