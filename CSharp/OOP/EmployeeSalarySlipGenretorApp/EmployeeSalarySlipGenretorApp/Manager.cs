using System;
namespace EmployeeSalarySlipGenretorApp
{
    class Manager : Employee
    {
        private double _hra;
        private double _ta;
        private double _da;

        public Manager(string name, string dateofjoin, double salary, string employeetype) : base(name, dateofjoin, salary, employeetype)
        {
            _hra = 0.5 * salary;
            _ta = 0.4 * salary;
            _da = 0.3 * salary;

        }
        public double HouseRentalAllowance
        {
            get
            {
                return _hra;
            }
        }
        public double TravellingAllowance
        {
            get
            {
                return _ta;
            }
        }
        public double DearnessAllowance
        {
            get
            {
                return _da;
            }
        }
        public double TotalSalay
        {
            get
            {
                return Salary + _hra + _da + _ta;
            }
        }
        public override string ToString()
        {
            return " HRA " + _hra.ToString() + "\n DA " + _da.ToString() + "\n TA " + _ta.ToString() +
                "\n Total Salary " + TotalSalay.ToString() + " Experience " + Experience;
        }
        public string Experience
        {
            get
            {
                DateTime dateOfJoining = DateTime.Parse(DateOfJoin, System.Globalization.CultureInfo.InstalledUICulture);
                DateTime currentDate = DateTime.Now;
                int month = currentDate.Month - dateOfJoining.Month;
                int year = currentDate.Year - dateOfJoining.Year;
                
                return (year.ToString()+"." + month.ToString());
            }

        }

    }
}
