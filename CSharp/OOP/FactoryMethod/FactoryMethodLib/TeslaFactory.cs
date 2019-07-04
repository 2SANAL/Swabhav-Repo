using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib
{
    public class TeslaFactory : IAutoMobileFactory
    {
        private static TeslaFactory _teslaFactory;

        private TeslaFactory() { }
        public IAutoMobile Make()
        {
            return new Tesla();
        }
        public static IAutoMobileFactory GetInstance()
        {
            if (_teslaFactory == null)
            {
                _teslaFactory = new TeslaFactory();
            }
            return _teslaFactory;
        }

    }
}
