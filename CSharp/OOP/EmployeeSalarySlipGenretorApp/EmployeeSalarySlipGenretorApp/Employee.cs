
namespace EmployeeSalarySlipGenretorApp
{

    abstract class Employee
    {
        private string _name;
        private string _dateOfJoining;
        private double _basicSalary;
        private string _employeType;
        public Employee() { }
        public Employee(string name, string dateofjoin, double salary, string employeetype)
        {
            _name = name;
            _dateOfJoining = dateofjoin;
            _basicSalary = salary;
            _employeType = employeetype;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string DateOfJoin
        {
            get
            {
                return _dateOfJoining;
            }
        }
        public double Salary
        {
            get
            {
                return _basicSalary;
            }
        }
        public string EmployeeType
        {
            get
            {
                return _employeType;
            }
        }


    }
}
