using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RickGuitarAPP
{
    class ConvertToString
    {
        public string BuliderToString(Builder builder)
        {
            if (builder.Equals(Builder.COLLINGS))
                return "Collings";
            if (builder.Equals(Builder.FENDER))
                return "Fender";
            if (builder.Equals(Builder.GIBSON))
                return "Gibson";
            if (builder.Equals(Builder.MARTIN))
                return "Martin";
            if (builder.Equals(Builder.OLSON))
                return "Olson";
            if (builder.Equals(Builder.PRS))
                return "PRS";
            if (builder.Equals(Builder.RYAN))
                return "Ryan";
            return null;
        }
        public string TypeToString(Type type)
        {
            if (type.Equals(Type.ACOUSTIC))
                return "Acoustic";
            if (type.Equals(Type.ELECTRIC))
                return "Electric";
            
            return null;
        }
        public String WoodToString(Wood wood)
        {
            if (wood.Equals(Wood.ADIRONDACK))
                return "Adiroudack";
            if (wood.Equals(Wood.ALDER))
                return "Alder";
            if (wood.Equals(Wood.BRAZILIAN_ROSEWOOD))
                return "Brazilian Rosewood";
            if (wood.Equals(Wood.CEDAR))
                return "Cedar";
            if (wood.Equals(Wood.COCOBOLA))
                return "Cocoboaa";
            if (wood.Equals(Wood.ADIRONDACK))
                return "Adiroudack";

            return null;
        }

    }
}
