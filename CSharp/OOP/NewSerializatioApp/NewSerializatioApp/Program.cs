using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using HumanApp;

namespace NewSerializatioApp
{
    class Program
    {
        private static readonly string path = @"E:\Example.txt";
        static void Main(string[] args)
        {
            Human human = new Human("dhruv", 12.3f, 55.2f);
            human.Workout();
            human.eat();
            DisplayInfo(human);

            serialiacle(human);
            Deserialization(human);
           

            DisplayInfo(human);




        }
        public static void DisplayInfo(Human objhuman)
        {
            Console.WriteLine(objhuman.getWeight());
            Console.WriteLine(objhuman.getWeight() + " " + objhuman.getHeight());
        }
        public static void serialiacle(Human human)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, human);
            stream.Close();
        }
        public static void Deserialization(Human human)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            Human objhuman = (Human)formatter.Deserialize(stream);
        }

       
    }
}
