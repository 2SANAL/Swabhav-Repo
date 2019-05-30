using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class Parent
    {
       public  string name = "hari";
        public int age = 20;
        private string address = "mumbai";
        public void Details()
        {
            Console.WriteLine("Parent class");
            Console.WriteLine("Name " + name + " age " + age + " address " + address);
        }
    }
    class child : Parent
    { 

        public void CDetails()
        {
            Console.WriteLine("Chlid class");
            Console.WriteLine("Name "+name+" age "+age);
        }

    }
}
