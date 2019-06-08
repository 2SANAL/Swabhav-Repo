using System;


namespace GenericApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Generic<string> generic1 = new Generic<string>();
            generic1.Value = "hello";
            Console.WriteLine(generic1.Value);
            Generic<float> generic2 = new Generic<float>();
            generic1.Value =45.5f.ToString();
            Console.WriteLine(generic1.Value);

            Display<int>("Integer", 12);
            Display<string>("String", "abc");
        }
        public static void Display<TypeOfValue>(string message, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}",message,value);
        }
    }
}
