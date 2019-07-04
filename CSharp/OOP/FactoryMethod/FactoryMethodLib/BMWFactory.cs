using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib
{
    public class BMWFactory : IAutoMobileFactory
    {
        private static BMWFactory _bmwFactory;

        public BMWFactory() { }

        public IAutoMobile Make()
        {
            return new BMW();
        }

        public static IAutoMobileFactory GetInstance()
        {
            if (_bmwFactory == null)
            {
                _bmwFactory= new BMWFactory();
            }
            return _bmwFactory;
        }
    }
}
