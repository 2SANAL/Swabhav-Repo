using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerApp
{
    class Player
    {
        private readonly int _id;
        private readonly string _name;
        private readonly GenderOptions _gender;
        private int _age;

        public Player(int _id, string _name, GenderOptions _gender)
        {
            this._id = _id;
            this._name = _name;
            this._gender = _gender;
        }
        public Player(int _id, string _name) : this(_id, _name, GenderOptions.MALE)
        {
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public int GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public GenderOptions GetGender()
        {
            return _gender;
        }
        public Player WhoElder(Player obj)
        {
            if (obj.Age > this.Age)
            {
                return obj;
            }
            else
            {
                return this;
            }
        }
    }
}
