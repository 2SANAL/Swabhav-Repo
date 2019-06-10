
namespace EngineeringCollegeApp
{
    class Professor : Person, ISalariedEmployee
    {
        private double _salary;
        private double _bonus;

        public Professor(int id, string address, string dateOfBarth, double salary) : base(id, address, dateOfBarth)
        {
            _salary = salary;
        }
        
        public double Salary
        {
            get
            {
                return _salary;
            }
        }

        public double CalaculateSalary()
        {
            _bonus = 0.8 * _salary;
            return _bonus;
        }
        
    }
}
