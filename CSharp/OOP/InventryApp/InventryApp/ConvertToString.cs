using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventryApp
{
    class ConvertToString
    {
        public string Convertor(Builder builder)
        {
            if (builder.Equals(Builder.COLLINGS))
            {
                return "Collings";
            }
            if (builder.Equals(Builder.FENDER))
            {
                return "Fender";
            }
            if (builder.Equals(Builder.GIBSON)){
                return "Gibson";
            }
            if (builder.Equals(Builder.MARTIN))
            {
                return "Martin";
            }
            if (builder.Equals(Builder.OLSON))
            {
                return "Olson";
            }
            if (builder.Equals(Builder.PRS))
            {
                return "PRS";
            }
            if (builder.Equals(Builder.RYAN))
            {
                return "Ryan";
            }
            return null;

        }
    }
}
