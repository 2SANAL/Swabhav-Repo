﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodLib
{
  public  interface IAutoMobileFactory
    {
        IAutoMobile Make();   
    }
}
