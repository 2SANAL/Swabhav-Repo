using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ContactApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Conact contact = new Conact("abc", "abc@as.com", 8446997740);
            contact.AddContact(contact);
            ArrayList list = contact.GetArraylist();
            foreach (Conact contact1 in list)
            {
                Display(contact1);
               
            }

        }
        public static void Display(Conact obj)
        {
            Console.WriteLine("Name "+obj.GetName()+" Email "+obj.GetEmail()+" Phone "+obj.GetPhone());
        }
    }
}
