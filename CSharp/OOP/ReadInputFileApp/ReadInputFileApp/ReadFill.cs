using System;
using System.IO;
namespace ReadInputFileApp
{
    class ReadFill
    {
        static readonly string filePath = @"E:\SwabhavTech\Sawbhav DAy1.txt";

        public void ReadFiletext()
        {
            Console.WriteLine("READ TEXT");
            if (File.Exists(filePath))
            {

                string text = File.ReadAllText(filePath);
                Console.WriteLine(text);
            }
        }

        public void ReadFileLine()
        {
            Console.WriteLine("READ LINE");
            if (File.Exists(filePath))
            {
                string[] line = File.ReadAllLines(filePath);
                foreach (string l in line)
                {
                    Console.WriteLine(l);
                }
            }
        }

        public void ReadFileStream()
        {
            Console.WriteLine("READ STREAM");
            using (StreamReader file = new StreamReader(filePath))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine("File count line " + counter);
            }

        }

    }

}

