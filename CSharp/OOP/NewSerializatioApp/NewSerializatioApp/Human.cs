using System;
using System.Text;

namespace HumanApp
{
    [Serializable]
    class Human
    {
        private readonly string _name;
        private float _height;
        private float _weight;
        private readonly int _age;
        private string _gender;
        private const string GENDER= "MALE";
        private const float DECWEIGHT = (2 / 100);
        private const float INCEHEIGHT = 0.5f;
        private const float INCEWIGHT = (1 / 100);


        public Human(string name, float height, float weight, int age)
        {
            this._name = name;
            this._height = height;
            this._weight = weight;
            this._age = age;
            this._gender = GENDER;

        }
        public Human(string name, float height, float weight) : this(name, height, weight, 18)
        {
        }

        public string Gender
        {
            set
            { 
               if (value == "femael" || value == "male")
                {
                    value.ToUpper();
                }
                else
                {
                    this._gender = value.ToUpper();
                }
            }
            get
            {
                return this._gender;
            }
        }

        public string getName()
        {
            return this._name;
        }
        public float getHeight()
        {
            return this._height;
        }
        public float getWeight()
        {
            return this._weight;
        }
        public int getAge()
        {
            return this._age;
        }

        public void Workout()
        {
            this._weight = _weight - DECWEIGHT;
        }
        public void eat()
        {
            this._weight = _weight + INCEWIGHT;
            this._height = _height + INCEHEIGHT;
        }
    }
}
