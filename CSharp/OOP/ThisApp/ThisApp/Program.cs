using System;

namespace ThisApp
{class Student
    {
        public string name,subject;
        int id,age;
        public Student(int id,string name,int age,string subject):this(name)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.subject = subject;
            Console.WriteLine("4 parameter");
            Console.WriteLine(id+" "+name + " " +age + " " +subject);
        }
        public Student(string name)
        {
            Console.WriteLine("Name Constructure");
            Console.WriteLine("Name "+name);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(101, "Dhruv", 21, "pooja");

        }
    }
}
