using System;


namespace RestrictionApp
{
    class Restrict
    {
        public  Restrict()
        {
            Console.WriteLine("sealed class");
        }
        public virtual void m1()
        {
            Console.WriteLine("sealed m1 ()");
        }
        
    }
    class Derived:Restrict
    {
        public void m3()
        {
            Console.WriteLine("Derived m1 method");
        }
         public override void m1()
        {

        }
    }
    
}
