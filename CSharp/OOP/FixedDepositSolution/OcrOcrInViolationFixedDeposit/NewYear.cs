using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OcrOcrInViolationFixedDeposit
{
    class NewYear : IRateDiside
    {
        private float _rate = 0.09f;

        public string GetFestivalName()
        {
            return "New Year";
        }
        public float GetRate()
        {
            return _rate;
        }
    }
}
