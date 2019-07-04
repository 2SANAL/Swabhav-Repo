using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspViolation
{
    class Rectangle
    {
        protected int _width;
        protected int _hight;

        public Rectangle(int width, int hight)
        {
            _width = width;
            _hight = hight;

        }
        public virtual void Setwidth(int width)
        {
            _width = width;
        }
        public virtual void SetHight(int hight)
        {
            _hight = hight;
        }
        public virtual int GetWidth()
        {
            return _width;
        }
        public int GetHight()
        {
            return _hight;
        }
        public int CalculateArea()
        {
            return _width * _hight;
        }
    }

}
