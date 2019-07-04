using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspInViolation
{
    class Rectangle : IShapes
    {
        private int _width;
        private int _hight;

        public Rectangle(int width, int hight)
        {
            _hight = hight;
            _width = width;
        }

        public int AreaCalaculation()
        {
            return _hight * _width;
        }
        public int GetHight()
        {
            return _hight;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetHight(int hight)
        {
              _hight = hight;
        }

        public void Setwidth(int width)
        {
             _width = width;
        }
    }
}
