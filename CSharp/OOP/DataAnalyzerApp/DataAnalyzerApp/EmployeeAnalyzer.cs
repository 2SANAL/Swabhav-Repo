using System.Collections.Generic;
using System.Collections;

namespace DataAnalyzerApp
{
    class EmployeeAnalyzer
    {
        Dictionary<Employee, Employee> employeeList = new Dictionary<Employee, Employee>();
        private double _maxSalary = 0;
        private Employee _maxSalaryEmploye;
        private Employee _employee1;
        private Dictionary<string, int> countDepartmentWise = new Dictionary<string, int>();
        private Dictionary<string, int> countDesignationWise = new Dictionary<string, int>();


        public EmployeeAnalyzer(Dictionary<Employee, Employee> employeeList)
        {
            this.employeeList = employeeList;
        }

        public void MaxSalary()
        {
            double salary;

            foreach (KeyValuePair<Employee, Employee> employeeObj in employeeList)
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
            foreach (KeyValuePair<Employee, Employee> employeeObj in employeeList)
            {
                _employee1 = employeeObj.Value;

                if (countDepartmentWise.ContainsKey(_employee1.DepartmentNumber))
                {
                    countDepartmentWise.TryGetValue(_employee1.DepartmentNumber, out result);
                    countDepartmentWise[_employee1.DepartmentNumber] = result + 1;

                }
                if (!countDepartmentWise.ContainsKey(_employee1.DepartmentNumber))
                {
                    countDepartmentWise.Add(_employee1.DepartmentNumber, 1);
                }

            }
        }

        public void DesignationWiseEmployeeCount()
        {

            int result = 0;
            foreach (KeyValuePair<Employee, Employee> employeeObj in employeeList)
            {
                _employee1 = employeeObj.Value;

                if (countDesignationWise.ContainsKey(_employee1.EmployeeDesignation))
                {
                    countDesignationWise.TryGetValue(_employee1.EmployeeDesignation, out result);
                    countDesignationWise[_employee1.EmployeeDesignation] = result + 1;

                }
                if (!countDesignationWise.ContainsKey(_employee1.EmployeeDesignation))
                {
                    countDesignationWise[_employee1.EmployeeDesignation] = 1;
                }

            }
        }
        public Employee GetMaxSalaryEmployee
        {
            get
            {
                return _maxSalaryEmploye;
            }
        }
        public Dictionary<string, int> GetDepartmentWiseEmployee
        {
            get
            {
                return countDepartmentWise;
            }
        }
        public Dictionary<string, int> GetDesignationWiseCount
        {
            get
            {
                return countDesignationWise;
            }
        }

    }
}
