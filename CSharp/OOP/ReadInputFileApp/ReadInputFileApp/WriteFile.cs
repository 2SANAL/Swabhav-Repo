using System;
using System.IO;

namespace ReadInputFileApp
{
    class WriteFile
    {
        static readonly string filePath = @"E:\SwabhavTech\Writetext.txt";
        string[] line = { "Dipesh", "Dhruv", "Akash", "JAmes", "Akhilesh" };

        public void WriteDataToFileUArray()
        {
            
            File.WriteAllLines(filePath, line);

            Console.WriteLine(File.ReadAllText(filePath));

        }
        public void WriteDataText()
        {
            string text= "A class is the most powerful data type in C#. Like a structure, " +
                       "a class defines the data and behavior of the data type. ";
            File.AppendAllText(filePath, text);
 
            Console.WriteLine(File.ReadAllText(filePath));
        }
        public void StreamWrite()
        {
            using (StreamWriter file =
            new System.IO.StreamWriter(filePath))
            {
                foreach (string l in line)
                {
                    
                    if (!l.Contains("Akash"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            Console.WriteLine(File.ReadAllText(filePath));
        }

    }
}
