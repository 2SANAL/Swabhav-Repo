using System;
using System.Net;
using System.Net.Mail;


namespace EmailSendApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter receiver email id : ");
            string receiverMail = Console.ReadLine();
            Email email = new Email();
            email.SendMail(receiverMail);
            Console.WriteLine("Email sent Successfully");
        }
    }
}
