using System.Collections.Generic;
using System.Collections;

namespace DataAnalyzerApp
{
    class EmployeeAnalyzer
    {

        private readonly DataParser _dataParser;

        private Dictionary<Employee, Employee> _employeeList = new Dictionary<Employee, Employee>();
        private double _maxSalary = 0;
        private Employee _maxSalaryEmploye;
        private  Employee _employee1;
        private Dictionary<string, int> _countDepartmentWise = new Dictionary<string, int>();
        private Dictionary<string, int> _countDesignationWise = new Dictionary<string, int>();

        public EmployeeAnalyzer(DataParser dataParser)
        {
            _dataParser = dataParser;
            MaxSalary();
            DepartmentWiseEmployeeCount();
            DesignationWiseEmployeeCount();
        }

        public void MaxSalary()
        {
            double salary;
            _employeeList = _dataParser.EmployeeList;

            foreach (KeyValuePair<Employee, Employee> employeeObj in _employeeList)
            {
                _employee1 = employeeObj.Value;
                salary = double.Parse(_employee1.Salary);

                if (salary > _maxSalary)
                {
                    _maxSalary = salary;
                    _maxSalaryEmploye = _employee1;
                }
            }
        }
        public void DepartmentWiseEmployeeCount()
        {

            int result = 0;
            _employeeList = _dataParser.EmployeeList;
            foreach (KeyValuePair<Employee, Employee> employeeObj in _employeeList)
            {
                _employee1 = employeeObj.Value;

                if (_countDepartmentWise.ContainsKey(_employee1.DepartmentNumber))
                {
                    _countDepartmentWise.TryGetValue(_employee1.DepartmentNumber, out result);
                    _countDepartmentWise[_employee1.DepartmentNumber] = result + 1;

                }
                if (!_countDepartmentWise.ContainsKey(_employee1.DepartmentNumber))
                {
                    _countDepartmentWise.Add(_employee1.DepartmentNumber, 1);
                }

            }
        }

        public void DesignationWiseEmployeeCount()
        {
            _employeeList = _dataParser.EmployeeList;
            int result = 0;
            foreach (KeyValuePair<Employee, Employee> employeeObj in _employeeList)
            {
                _employee1 = employeeObj.Value;

                if (_countDesignationWise.ContainsKey(_employee1.EmployeeDesignation))
                {
                    _countDesignationWise.TryGetValue(_employee1.EmployeeDesignation, out result);
                    _countDesignationWise[_employee1.EmployeeDesignation] = result + 1;

                }
                if (!_countDesignationWise.ContainsKey(_employee1.EmployeeDesignation))
                {
                    _countDesignationWise[_employee1.EmployeeDesignation] = 1;
                }

            }
        }
        public Employee MaxSalaryEmployee
        {
            get
            {
                return _maxSalaryEmploye;
            }
        }
        public Dictionary<string, int> DepartmentWiseEmployee
        {
            get
            {
                return _countDepartmentWise;
            }
        }
        public Dictionary<string, int> DesignationWiseCount
        {
            get
            {
                return _countDesignationWise;
            }
        }

    }
}
