using System.Collections.Generic;

namespace AppliationContact
{
    class PhoneBook
    {
        private List<Contact> _contactList;
        private Service _serializaeddesrialized;

        public PhoneBook()
        {
            _contactList = new List<Contact>();
            _serializaeddesrialized = new Service();
        }
        public void AddContact(string name, string email, string phonenumber)
        {
            _serializaeddesrialized.Deserialization();
            _contactList.Add(new Contact(name, email, phonenumber));
            _serializaeddesrialized.Serialization(_contactList);
        }
        public List<Contact> GetContact()
        {
            _contactList = _serializaeddesrialized.Deserialization();
            return _contactList;
        }
    }
}