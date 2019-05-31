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

        public Player(int _id, string _name, GenderOptions _gender)
        {
            _id = _id;
            _name = _name;
            _gender = _gender;
        }
        public Player(int _id, string _name) : this(_id, _name, GenderOptions.MALE)
        {
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
    }
}
