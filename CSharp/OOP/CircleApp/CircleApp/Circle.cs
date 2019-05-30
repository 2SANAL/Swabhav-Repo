using System;

namespace CircleApp
{
    class Circle
    {
        private float _redius;
        private const float PI = 3.14f;

        public float Redius
        {
            get
            {
                return _redius;
            }
            set
            {
                _redius = value;
            }
        }
        public float CalArea()
        {
            return PI * _redius * _redius;
        }

    }
}
