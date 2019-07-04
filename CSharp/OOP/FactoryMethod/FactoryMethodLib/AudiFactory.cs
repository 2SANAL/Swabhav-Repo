using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib
{
  public  class AudiFactory : IAutoMobileFactory
    {
        private static AudiFactory _audiFactory;

        public AudiFactory()
        {

        }

        public IAutoMobile Make()
        {
            return new Audi();
        }

        public static IAutoMobileFactory GetInstance()
        {
            if (_audiFactory == null)
            {
                _audiFactory= new AudiFactory();
            }
            return _audiFactory;
        }

    }
}
