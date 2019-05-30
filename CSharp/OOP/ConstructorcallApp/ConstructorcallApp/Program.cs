using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorcallApp
{
    class Program
    {   public Program():this(10,20){
            Console.WriteLine("non- parameter constructor");
            }
        public Program(int a,int b)
        {
            Console.WriteLine("a "+a +" b "+b);
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();
        }
    }
}
