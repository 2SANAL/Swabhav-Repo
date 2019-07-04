using System;

namespace AutoMobileLib
{
    class BMW : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("BMW Start");
        }

        public void Stop()
        {
            Console.WriteLine("BMW Stop");
        }
    }
}
