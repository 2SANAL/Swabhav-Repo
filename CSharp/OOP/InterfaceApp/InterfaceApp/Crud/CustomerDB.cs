using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
    class CustomerDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer Create ");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Delete ");
        }

        public void Read()
        {
            Console.WriteLine("Customer Read ");
        }

        public void Update()
        {
            Console.WriteLine("Customer Update ");
        }
    }
}
