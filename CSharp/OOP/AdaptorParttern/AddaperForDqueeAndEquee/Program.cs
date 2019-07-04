using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddaperForDqueeAndEquee
{
    class Program
    {
        private

         static void Main(string[] args)
        {
            IQueue<int> queue = new QueueAdapter<int>();
            queue.Enquee(12);
            queue.Enquee(20);
            queue.Enquee(30);
            Console.WriteLine(queue.Count());
            Console.WriteLine("Deleted Element :" + queue.Dequee());
            Console.WriteLine(queue.Count());

            foreach(int element in queue)
            {
                Console.WriteLine(element);
            }
        }

    }
}
