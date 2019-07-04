using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            Case2();

        }

        //private static void Case1()
        //{
        //      DataServer server1 = new DataServer();
        //    DataServer server2 = new DataServer();

        //    Console.WriteLine(server1.GetHashCode());
        //    Console.WriteLine(server2.GetHashCode());

        //    server1.DoSomthing();
        //    server2.DoSomthing();
        //}

        private static void Case2()
        {
            DataServer server1 = DataServer.GetInstance();
            DataServer server2 = DataServer.GetInstance();

            Console.WriteLine(server1.GetHashCode());
            Console.WriteLine(server2.GetHashCode());

            server1.DoSomthing();
            server2.DoSomthing();

        }

    }
}
