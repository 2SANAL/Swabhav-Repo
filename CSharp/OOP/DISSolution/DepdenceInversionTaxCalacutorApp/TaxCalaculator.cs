using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepdenceInversionTaxCalacutorApp
{
    class TaxCalaculator
    {
        private LogType _log;

        public TaxCalaculator(LogType log)
        {
            _log = log;
        }
        public int Calculator(int income, int rate)
        {
            int result = 0;
            try
            {
                result = income / rate;
            }
            catch (Exception exception)
            {
                if (_log.Equals(LogType.DATABASE))
                {
                    DataBaseLogger dataBaseLogger = new DataBaseLogger();
                    dataBaseLogger.Log(exception.Message);
                }
                else
                {
                    FileLogger fileLogger = new FileLogger();
                    fileLogger.Log(exception.Message);
                }
            }
            return result;
        }



    }
}
