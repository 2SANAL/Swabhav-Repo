using System;

namespace encapsulationApp
{
    class user
    {
        private string location;
        private string name;
        public String Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            user u = new user();
            u.Location = "mumbai";
            u.Name = "Dhruv";
            Console.WriteLine("NAme " + u.Name);
            Console.WriteLine("Location " + u.Location);
        }
    }
}
