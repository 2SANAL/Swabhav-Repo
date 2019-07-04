using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternApp
{
    class DataServer
    {
        private static DataServer _container;

        private DataServer()
        {
            Console.WriteLine(" Service created ");
        }

        public void DoSomthing()
        {
            Console.WriteLine("Do somthing  " + this.GetHashCode());
        }

        public static DataServer GetInstance()
        {
            if (_container == null)
            {
                _container = new DataServer();
            }
            return _container;
        }
    }
}
