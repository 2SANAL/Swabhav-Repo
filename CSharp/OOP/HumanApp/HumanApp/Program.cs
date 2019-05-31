using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("dhruv", 4.5f, 52.0f, 20);
            Human h2 = new Human("Akash", 5.6f, 40.5f);

            Console.WriteLine("Before Workout");
            h1.Gender = "MALE";
            h2.Gender = "FEMALE";
            printInfo(h1);
            printInfo(h2);

            Console.WriteLine("\nAfter Workout ");
            h1.Workout();
            h2.Workout();
            h1.Gender = "MALE";
            h2.Gender = "FEMALE";
            printInfo(h1);
            printInfo(h2);

            Console.WriteLine("\nAfter Eat ");
            h1.eat();
            h2.eat();
            h1.Gender = "MALE";
            h2.Gender = "FEMALE";
            printInfo(h1);
            printInfo(h2);


        }
        public  static void printInfo(Human obj)
        {
            Console.WriteLine("Human Name: " + obj.getName() + " \nHeight: " + obj.getHeight() + "inch " + " \nWeight: " + obj.getWeight() +"kg "+ " \nAge: " + obj.getAge()+" \nGender "+obj.Gender);
            
        }
        

    }
    
}
