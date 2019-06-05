using System;


namespace OddEvenNumberApp
{
    class Program
    {
        static int[] evennumber;
        static int[] oddnumber;
        static int index = 0;
        static void Main(string[] args)
        {

            OddEvenNumberChecker numbercheck = new OddEvenNumberChecker(100);
            numbercheck.EvenOddNumberChecker();
            evennumber = numbercheck.GetEvenNumberArray();
            oddnumber = numbercheck.GetOddNumberArray();
            while (index < evennumber.Length)
            {   
                Console.WriteLine(evennumber[index] +" Number is even ");
                index++;
            }
            index = 0;
            while (index < oddnumber.Length-1)
            {
                Console.WriteLine(oddnumber[index] + " Number is odd");
                index++;
            }
        } 
    }
}
