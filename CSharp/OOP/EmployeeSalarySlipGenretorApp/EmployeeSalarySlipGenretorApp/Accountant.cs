using System;
namespace EmployeeSalarySlipGenretorApp
{
    class Accountant : Employee
    {
        private double _parks;
        public Accountant(string name, string dateofjoin, double salary, string employeetype) : base(name, dateofjoin, salary, employeetype)
        {
            _parks = 0.3 * salary;
        }
        public double Parks
        {
            get
            {
                return _parks;
            }
        }
        public double ToatalSalary
        {
            get
            {
                return Salary + _parks;
            }
        }
        public override string ToString()
        {
            return " Park :" + _parks.ToString() + "\n Total Salary :" + ToatalSalary.ToString() + " Experience " + Experience; ;
        }
        public string Experience
        {
            get
            {
                DateTime dateOfJoining = DateTime.Parse(DateOfJoin, System.Globalization.CultureInfo.InstalledUICulture);
                DateTime currentDate = DateTime.Now;
                int month = currentDate.Month - dateOfJoining.Month;
                int year = currentDate.Year - dateOfJoining.Year;

                return (year.ToString() + "." + month.ToString());
            }

        }
    }
}
