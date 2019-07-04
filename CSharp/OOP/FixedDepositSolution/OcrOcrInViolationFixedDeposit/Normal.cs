using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OcrOcrInViolationFixedDeposit
{
    class Normal : IRateDiside
    {
        private float _rate = 0.07f;

        public string GetFestivalName()
        {
            return "Normal";
        }
        public float GetRate()
        {
            return _rate;
        }
    }
}
