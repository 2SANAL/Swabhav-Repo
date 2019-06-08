using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactApplication
{[Serializable]
    class Contact
    {
        private string _name;
        private string _email;
        private double _phonenumber;

        public Contact(string name, string email, double phonenumber)
        {
            _email = email;
            _name = name;
            _phonenumber = phonenumber;
        }
        public double PhoneNumber
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