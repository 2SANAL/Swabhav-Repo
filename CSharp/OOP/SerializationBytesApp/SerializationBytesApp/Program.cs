using System;
using System.Collections.Generic;
using System.IO;

namespace SerializationBytesApp
{
    class MyBinaryFormatter
    {
        static void Main(string[] args)
        {
            List<string> student = new List<string>();
            student.Add("dhruv ");
            student.Add("Akash");
            student.Add("Dipesh");
            student.Add("sanal");

            FileStream FS = new FileStream("Student.txt", FileMode.Create);
            Serialize serialize=new Serialize();
            serialize.Serializing(student, FS);
            FS.Flush();
            FS.Close();

            FS = new FileStream("Student.txt", FileMode.Open);
            Deserialize deserialize = new Deserialize();
            List<string> student2 = deserialize.Deserializing(FS);
            FS.Close();

            if (student2 != null)
            {
                foreach (string Customer in student2)
                {
                    Console.WriteLine(Customer);
                }
            }
            Console.ReadLine();

        }
       
        
    }
}
