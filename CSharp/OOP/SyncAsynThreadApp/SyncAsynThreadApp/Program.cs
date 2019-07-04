using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SyncAsynThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    case1();
            case2();
        }
        private static void case1()
        {
            Application.EnableVisualStyles();
            Application.Run(new Synchronus());
        }
        private static void case2()
        {
            Application.EnableVisualStyles();
            Application.Run(new Asyncronus());
        }
    }
}
