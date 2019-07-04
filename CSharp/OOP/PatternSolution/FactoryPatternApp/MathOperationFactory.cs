using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternApp
{
    class MathOperationFactory
    {
        public IMathoperation GetOperation(string mathOperationType)
        {
            if (mathOperationType == null)
            {
                return null;
            }
            if (mathOperationType.Equals("ADDITION"))
            {
                return new Addition();

            }
            if (mathOperationType.Equals("POWER"))
            {
                return new Power();
            }
            return null;
        }
    }
}
