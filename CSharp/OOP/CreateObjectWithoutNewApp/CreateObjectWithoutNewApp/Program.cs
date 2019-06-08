using System;


namespace CreateObjectWithoutNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(WithoutName);
            object obj = Activator.CreateInstance(type);
            WithoutName withoutname = obj as WithoutName;
            withoutname.Display();
        }
    }
}
