using System;

namespace ObjectCalisthenicsOnlyOneLevelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 15, 25, 36, 48, 1, 55 };
            int[] getdata;
            OnlyOneLevel onlyonelevel = new OnlyOneLevel(data);
            //  onlyonelevel.Bublesort();
            onlyonelevel.OnlyOneLevelBubbleSor1();
            getdata = onlyonelevel.getdata();
            for (int index = 0; index < getdata.Length; index++)
            {
                Console.WriteLine(getdata[index]);
            }

        }
    }
}
