using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ContactApp
{
    class Conact
    {
        private string _name;
        private string _email;
        private double _phone;
        private ArrayList list;

        public Conact(string name,string email,double phone)
        {
            _name = name;
            _email = email;
            _phone = phone;
        }
        public void AddContact(Conact conact)
        {
            list.Add(conact);
        }
        public ArrayList GetArraylist()
        {
            return list;
        }
        public  string GetName()
        {
            return _name;
        }
        public string GetEmail()
        {
            return _email;
        }
        public double GetPhone()
        {
            return _phone;
        }
    }
}
