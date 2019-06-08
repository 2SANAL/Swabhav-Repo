using System;
using MAnBoyApp.Constructor.Case1;

namespace ManBoyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();
            //CaseStudy5();
            CaseStudy6();

        }
        public static void CaseStudy1()
        {
            Man man;
            man = new Man();
            man.Play();
            man.Walk();
        }
        public static void CaseStudy2()
        {
            Boy boy;
            boy = new Boy();
            boy.Play();
            boy.Walk();
            boy.eat();
        }
        public static void CaseStudy3()
        {
            Man man;
            man = new Boy();
            man.Play();
            man.Walk();

        }
        public static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
        }
        public static void AtThePark(Man x)
        {
            Console.WriteLine("Inside the Park");
            x.Play();
        }
        public static void CaseStudy5()
        {
            new Child();
        }
        public static void CaseStudy6()
        {
            MAnBoyApp.Constructor.Case2.Child chile =   new MAnBoyApp.Constructor.Case2.Child();
            Console.WriteLine(chile.GetBar());
            MAnBoyApp.Constructor.Case2.Child chile1 = new MAnBoyApp.Constructor.Case2.Child(200);
            Console.WriteLine(chile1.GetBar());
        }
    }
}
