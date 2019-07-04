using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using FactoryMethodLib;
using System.Reflection;

namespace FactoryMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {




            //   Case1();
            Case2();
            Console.ReadKey();
        }
        private static void Case2()
        {
            IAutoMobile UR = CreateInstance<TeslaFactory>().Make();

            UR.Start();
            UR.Stop();

        }

        private static void Case1()
        {
            IAutoMobileFactory factory = BMWFactory.GetInstance();
            IAutoMobile autoMobile = factory.Make();

            autoMobile.Start();
            autoMobile.Stop();

            IAutoMobileFactory factory1 = AudiFactory.GetInstance();
            IAutoMobile autoMobile1 = factory1.Make();

            autoMobile1.Start();
            autoMobile1.Stop();

            IAutoMobileFactory factory2 = TeslaFactory.GetInstance();
            IAutoMobile autoMobile2 = factory2.Make();

            autoMobile2.Start();
            autoMobile2.Stop();
        }

        public static I CreateInstance<I>() where I : class
        {
            string assemblyPath = Environment.CurrentDirectory + "\\FactoryMethodLib.dll";
            string factoryClass = ConfigurationManager.AppSettings["factory"];

            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Type type = assembly.GetType(factoryClass);
            MethodInfo staticMethodInfo = type.GetMethod("GetInstance");
            var a = staticMethodInfo.Invoke(null, null);

            return a as I;
        }




    }
}
