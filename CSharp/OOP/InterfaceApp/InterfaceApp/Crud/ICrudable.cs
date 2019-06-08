using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
    interface ICrudable
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}
