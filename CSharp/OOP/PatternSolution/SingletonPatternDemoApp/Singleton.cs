using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternDemoApp
{
    class Singleton
    {
        private static Singleton _instance = new Singleton();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            return _instance;
        }
        public void ShowMessage()
        {
            Console.WriteLine("Singleton Pattern Demo ");
        }
    }
}
