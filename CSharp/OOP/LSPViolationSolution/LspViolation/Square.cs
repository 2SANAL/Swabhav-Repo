using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspViolation
{
    class Square : Rectangle
    {

        public Square(int side) : base(side, side)
        {

        }
        public override void SetHight(int hight)
        {
            _hight = _width = hight;
        }
        public override void Setwidth(int width)
        {
            _width = _hight = width;
        }

    }
}
