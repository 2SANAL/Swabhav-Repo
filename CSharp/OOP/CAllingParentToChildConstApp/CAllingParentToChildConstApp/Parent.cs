using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAllingParentToChildConstApp
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine( "Parent constructor");
        }
        public Parent(int a ,int b):this("dhruv",20)
        {
            Console.WriteLine(a+" "+b);
        }
        public Parent(string n,int age)
        {
            Console.WriteLine("Name "+n+" age "+age);
        }
       
    }
}
