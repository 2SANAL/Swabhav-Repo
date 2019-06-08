using System;


namespace MAnBoyApp.Constructor.Case1
{
    class Child:Parent
    {
       public Child():base()
        {
            Console.WriteLine("Inside Child");
        }       
    }
}
