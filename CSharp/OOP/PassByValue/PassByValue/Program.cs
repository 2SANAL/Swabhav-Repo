using System;

namespace PassByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks = 100;
            ChangeMarks(marks);
            Console.WriteLine(marks);
            int[] marks1 = { 10, 20, 30 };
            ChangeMarks(marks1);
            foreach (int i in marks1)
            {
                Console.WriteLine(i);
            }
        }
        private static void ChangeMarks(int m)
        {
            m = 0;
        }
        private static void ChangeMarks(int[] mark)
        {
            int i = 0;
            for (i = 0; i < mark.Length; i++)
            {
                mark[i] = 0;
            }
        }
    }
    

}

