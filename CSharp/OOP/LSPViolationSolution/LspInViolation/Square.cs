using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspInViolation
{
    class Square : IShapes
    {
        private int _side;
        private int _hight;
        private int _width;

        public Square(int side)
        {
            _side = side;
        }


        public int AreaCalaculation()
        {
            return _side * _side;
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
           _side= _hight = hight;
        }

        public void Setwidth(int width)
        {
            _side= _width = width;
        }
    }
}
