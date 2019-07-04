using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton instance1= new Singleton();
            Singleton instance = Singleton.GetInstance();
            instance.ShowMessage();
        }
    }
}
