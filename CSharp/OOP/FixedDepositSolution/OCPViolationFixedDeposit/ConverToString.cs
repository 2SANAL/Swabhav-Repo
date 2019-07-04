using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPViolationFixedDeposit
{
    class ConverToString
    {
        string festival;
        public string ConvertoString(FestivalType festivalType)
        {
           
            if (FestivalType.HOLI==festivalType)
            {
                festival= "Holi";
            }
            if (FestivalType.NEW_YEAR==festivalType)
            {
                festival= "New Year";
            }
            if (FestivalType.NORMAL==festivalType)
            {
                festival= "Normal";
            }
            return festival;
        }


    }
}
