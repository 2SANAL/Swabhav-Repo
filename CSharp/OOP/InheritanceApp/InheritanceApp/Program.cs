using System;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Parent p1 = new child();
            child c = new child();
           
            c.Details();
            c.CDetails();
        }
    }
}
