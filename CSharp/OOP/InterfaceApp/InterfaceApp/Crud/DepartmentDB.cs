using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
    class DepartmentDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine( "Department Create");
        }

        public void Delete()
        {
            Console.WriteLine("Department Delete");
        }

        public void Read()
        {
            Console.WriteLine("Department read");
        }

        public void Update()
        {
            Console.WriteLine("Department update");
        }
    }
}
