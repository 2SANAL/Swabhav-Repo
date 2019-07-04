using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPInViolationTaxCalculatoraApp
{
    class TaxCalaculator
    {
        private ILog _iLog;

        public TaxCalaculator(ILog iLog)
        {
            _iLog =iLog;
        }

        public  int Calaculator(int income,int rate)
        {
            int result = 0;
            try
            {
                result = income / rate;
            }
            catch(Exception exception)
            {
                _iLog.Log(exception.Message);
            }
            return result;
        }
    }
}
