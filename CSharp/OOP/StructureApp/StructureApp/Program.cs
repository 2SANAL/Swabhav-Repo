using System;

namespace StructureApp
{
    public struct Student
    {
        public string Name;
        public int age;
        public string address; 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1;
            s1.Name = "Dhruv";
            s1.age = 20;
            s1.address = "MiraRoad";

            Console.WriteLine("Name "+ s1.Name+"Age "+s1.age+" Address "+s1.address);
        }
    }
}
