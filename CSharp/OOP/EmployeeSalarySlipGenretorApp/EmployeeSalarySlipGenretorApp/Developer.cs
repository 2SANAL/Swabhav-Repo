using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeSalarySlipGenretorApp
{
    class Developer : Employee
    {
        private double _bonus;
        private double _performanceAllowance;

        public Developer(string name, string dateofjoin, double salary, string employeetype) : base(name, dateofjoin, salary, employeetype)
        {
            _bonus = 0.4 * salary;
            _performanceAllowance = 0.3 * salary;
        }
        public double Bonus
        {
            get
            {
                return _bonus;
            }
        }
        public double PerformanceAllowance
        {
            get
            {
                return _performanceAllowance;
            }
        }
        public double TotalSalary
        {
            get
            {
                return Salary + _bonus + _performanceAllowance;
            }
        }
        public override string ToString()
        {
            return " Bouns :" + _bonus.ToString() + "\n PA :" + _performanceAllowance.ToString() + "\n Toatal Salary :"
                + TotalSalary.ToString() + " Experience " + Experience;
        }
        public string Experience
        {
            get
            {
                DateTime dateOfJoining = DateTime.Parse(DateOfJoin, System.Globalization.CultureInfo.InstalledUICulture);
                DateTime currentDate = DateTime.Now;
                int month = currentDate.Month - dateOfJoining.Month;
                int year = currentDate.Year - dateOfJoining.Year;

                return (   year.ToString()+"."+month.ToString() );
            }

        }
    }
}
