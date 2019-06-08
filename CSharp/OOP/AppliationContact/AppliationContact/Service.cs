using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AppliationContact
{
    class Service
    {
        private List<Contact> _list;
        private string _path;
        public Service()
        {
            _list = new List<Contact>();
            _path = @"E:\\Contacts.txt";
        }
        public void Serialization(List<Contact> contactlist)
        {
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream fileout = new FileStream(_path, FileMode.Create, FileAccess.Write);
            using (fileout)
            {
                binaryformatter.Serialize(fileout, contactlist);
            }
        }
        public List<Contact> Deserialization()
        {
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream filein = new FileStream(_path, FileMode.Open, FileAccess.Read);
            using (filein)
            {
                _list = (List<Contact>)binaryformatter.Deserialize(filein);
            }
            return _list;
        }
        public void ExportContact()
        {
            string filePath = @"E:\\exportcontact.csv";
            PhoneBook phonebook = new PhoneBook();

            List<Contact> list = phonebook.GetContact();
            StringBuilder writedataintocsv = new StringBuilder();
            foreach (Contact contact in list)
            {

                var name = contact.Name.ToString();
                var email = contact.Email.ToString();
                var phonenumber = contact.PhoneNumber;
                var newLine = string.Format("{0},{1},{2}", name, email, phonebook);
                writedataintocsv.AppendLine(newLine);
            }
            File.AppendAllText(filePath, writedataintocsv.ToString());
        }

        public void SearchContac(string searchingitem)
        {
            PhoneBook phonebook = new PhoneBook();
            List<Contact> list = phonebook.GetContact();
            foreach (Contact contact in list)
            {
                if ((searchingitem.Equals(contact.Name)) || ((searchingitem.Equals(contact.Email)) || ((searchingitem.Equals(contact.PhoneNumber)))))
                {
                    ShowContactInformation(contact);
                }

            }

        }
        public void ShowContactInformation(Contact contact)
        {
            Console.WriteLine();
            Console.WriteLine("Name:" + contact.Name + "\nPhone No:" + contact.PhoneNumber + "\nEmail:" + contact.Email);
            Console.WriteLine();
        }
    }
}