using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapApp
{
    class Rectangle
    {
        private int _height;
        private int _width;

        public int GetHight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }
        public void SetWidth(int width)
        {
           
            this._width = width;
            if (width <= 0)
            {
                this._width = 1;
            }
            else if (width >= 100)
            {
                this._width = 100;
            }
        }
        public void SetHeight(int height) {
            this._height = height;
            if (height <= 0)
            {
                this._height = 1;
            }
            else if (height >= 100)
            {
                this._height = 100;
            }
        }
        public int CalculateArea()
        {
            return _width * _height;
        }

    }
}
