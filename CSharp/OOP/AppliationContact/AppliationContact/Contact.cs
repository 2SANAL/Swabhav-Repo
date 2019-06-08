using System;

namespace AppliationContact
{[Serializable]
    class Contact
    {
        private string _name;
        private string _email;
        private string _phonenumber;

        public Contact(string name, string email, string phonenumber)
        {
            _email = email;
            _name = name;
            _phonenumber = phonenumber;
        }
        public string PhoneNumber
        {
            get { return _phonenumber; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Email
        {
            get { return _email; }
        }

    }
}
