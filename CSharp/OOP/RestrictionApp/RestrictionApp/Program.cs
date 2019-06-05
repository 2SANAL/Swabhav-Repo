using System;

namespace RestrictionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Restrict restrict = new Restrict();
            Derived derived = new Derived();
            restrict.m1();
            derived.m1();
            derived.m3();
        }
    }
}
