using System;

namespace AutoMobileLib
{
    class Tesla : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla Start");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla Stop");
        }
    }
}
