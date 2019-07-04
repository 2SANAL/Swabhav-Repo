using System;
using AutoMobileLib;

namespace AutoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            Case2();
        }
        public static void Case2()
        {
            AutoMobileFactory autoMobileFactory = AutoMobileFactory.GetInstance();
            IAutoMobile iautoMobile;

            iautoMobile = autoMobileFactory.Make(AutoType.AUDI);
            Display(iautoMobile);
            iautoMobile = autoMobileFactory.Make(AutoType.BMW);
            Display(iautoMobile);
            iautoMobile = autoMobileFactory.Make(AutoType.TESLA);
            Display(iautoMobile);
        }
        private static void Display(IAutoMobile iautoMobile)
        {
            Console.WriteLine(iautoMobile.GetType());
            iautoMobile.Start();
            iautoMobile.Stop();
        }

        //private static void Case1()
        //{
        //    AutoMobileFactory autoMobileFactory = new AutoMobileFactory();
        //    IAutoMobile iautoMobile;

        //    iautoMobile = autoMobileFactory.Make(AutoType.AUDI);
        //    Display(iautoMobile);
        //    iautoMobile = autoMobileFactory.Make(AutoType.BMW);
        //    Display(iautoMobile);
        //    iautoMobile = autoMobileFactory.Make(AutoType.TESLA);
        //    Display(iautoMobile);
        //}

    }
}
