using System;

namespace AutoMobileLib
{
    class Audi : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Audi Start");
        }

        public void Stop()
        {
            Console.WriteLine("Audo Stop");
        }
    }
}
