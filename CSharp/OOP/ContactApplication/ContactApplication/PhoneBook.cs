using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ContactApplication
{
    class PhoneBook
    {
        private ArrayList _contactList;
        private SerializaedDeserialized _serializaeddesrialized;

        public PhoneBook()
        {
            _contactList = new ArrayList();
            _serializaeddesrialized = new SerializaedDeserialized();
        }
        public void AddContact(string name, string email, double phonenumber)
        {
            _serializaeddesrialized.Deserialization();
            _contactList.Add(new Contact(name, email, phonenumber));
            _serializaeddesrialized.Serialization(_contactList);
        }
        public ArrayList ShowContact()
        {
            _contactList = _serializaeddesrialized.Deserialization();
            return _contactList;
        }
    }
}