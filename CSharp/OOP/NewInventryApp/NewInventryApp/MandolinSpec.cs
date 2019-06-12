using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewInventryApp
{
    class MandolinSpec : InstrumentSpace
    {

        private Style style;

        public MandolinSpec(Builder builder, string model, Type type, Style style, Wood backwood, Wood topWood) : base(builder, model, type, backwood, topWood)
        {
            this.style = style;
        }
        public Style GetStyle()
        {
            return style; 
        }
        public bool matches(InstrumentSpace otherspec)
        {
            if (!base.matches(otherspec))
                return false;
            if (!(otherspec is MandolinSpec))
                return false;
            MandolinSpec spec = (MandolinSpec)otherspec;
            if (!style.Equals(spec))
                return false;
            return true;
        }

    }

}
