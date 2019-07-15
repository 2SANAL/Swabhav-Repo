using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingLib.Repository;
using System.Windows.Forms;

namespace BankingMdiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }
}
