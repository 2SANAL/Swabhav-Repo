using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
    class InvoiceDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Invoice Create");
        }

        public void Delete()
        {
            Console.WriteLine("Invoice  Delete ");
        }

        public void Read()
        {
            Console.WriteLine("Invoice read");
        }

        public void Update()
        {
            Console.WriteLine("Invoice Upadte");
        }
    }
}
