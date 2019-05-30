using System;

namespace RectangleEncapApp
{
    class Rectangle
    {
        private int _height;
        private int _width;
        private readonly int lowerBound = 0;
        private readonly int uperBound = 100;

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
            this._width = CheckCondition(width);
        }

        public void SetHeight(int height)
        {
            this._height = CheckCondition(height);
        }

        int CheckCondition(int value)
        {
            if (value <= lowerBound)
            {
                value = 1;
            }
            else if (value >= uperBound)
            {
                value = 100;
            }
            return value;
        }

        public int CalculateArea()
        {
            return _width * _height;
        }

    }
}
