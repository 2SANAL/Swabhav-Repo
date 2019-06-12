using System;


namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(args[0]);
                int b = Convert.ToInt32(args[1]);
                int c = a / b;
                Console.WriteLine("Result :" + c);
            }catch(IndexOutOfRangeException messsage)
            {
                Console.WriteLine("Message :"+messsage);
            }
            catch (OverflowException messsage)
            {
                Console.WriteLine("Message :" + messsage);
            }
            catch (DivideByZeroException messsage)
            {
                Console.WriteLine("Message :" + messsage);
            }
            catch (FormatException messsage)
            {
                Console.WriteLine("Message :" + messsage);
            }

            Console.WriteLine("End main");

         //   Main(args);
        }
    }
}
