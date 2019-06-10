using System;


namespace EngineeringCollegeApp
{
    class Person
    {
        private int _id;
        private string _address;
        private string _dateOfBarth;

        public Person() { }

        public Person(int id, string address, string dateOfBarth)
        {
            _id = id;
            _address = address;
            _dateOfBarth = dateOfBarth;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
        }

        public string DateOfBarth
        {
            get
            {
                return _dateOfBarth;
            }
        }

        public int Age
        {
            get
            {
                DateTime dateOfBarth = DateTime.Parse(_dateOfBarth,System.Globalization.CultureInfo.InstalledUICulture);
                DateTime currentDate = DateTime.Now;
                int year = currentDate.Year - dateOfBarth.Year;
                return year;
            }
        }
    }
}
