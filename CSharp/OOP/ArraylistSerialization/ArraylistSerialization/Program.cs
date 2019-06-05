using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using HumanApp;

namespace ArraylistSerialization
{
    class Program
    {
        static string path = @"E:/exp.txt";
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Human human1 = new Human("abc", 10.5f, 51.5f);
            Human human2 = new Human("xyz", 8.5f, 26.1f);
            list.Add(human1);
            list.Add(human2);

            IFormatter formatter = new BinaryFormatter();
            BinarySerialization(list, formatter);
            ArrayList list2 = Desrialization(formatter);

            foreach (Human human in list2)
            {
                ShowDetails(human);
            }



        }
        public static void BinarySerialization(ArrayList list, IFormatter formatter)
        {

            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, list);
            stream.Close();

        }
        public static ArrayList Desrialization(IFormatter formatter)
        {

            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            ArrayList list1 = (ArrayList)formatter.Deserialize(stream);
            stream.Close();
            return list1;
        }
        public static void ShowDetails(Human obj)
        {
            Console.WriteLine("Name " + obj.getName() + " Height " + obj.getHeight() + " Weight " + obj.getWeight());
        }
    }
}


