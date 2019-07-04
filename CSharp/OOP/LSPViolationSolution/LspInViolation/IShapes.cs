using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspInViolation
{
    interface IShapes
    {
        int AreaCalaculation();
        void SetHight(int hight);
        void Setwidth(int width);
        int GetHight();
        int GetWidth();
    }
}
