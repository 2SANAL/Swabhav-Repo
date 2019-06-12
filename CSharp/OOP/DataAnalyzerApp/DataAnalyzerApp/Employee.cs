using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAnalyzerApp
{
    class Employee
    {
        private readonly string _employeId;
        private readonly string _employeName;
        private readonly string _employeDesignation;
        private readonly string _managerId;
        private readonly string _dateOfJoin;
        private readonly string _salary;
        private readonly string _comission;
        private readonly string _departmentNumber;

        public Employee() { }
        public Employee(string employeeId, string employeeName, string employeeDesignation,
            string managerId, string dateOfJoin, string salary, string comission, string departmentNumber)
        {
            _employeId = employeeId;
            _employeName = employeeName;
            _employeDesignation = employeeDesignation;
            _managerId = managerId;
            _dateOfJoin = dateOfJoin;
            _salary = salary;
            _comission = comission;
            _departmentNumber = departmentNumber;
        }


             

        public string EmployeeId
        {
            get
            {
                return _employeId;
            }
        }
        public string EmployeeName
        {
            get
            {
                return _employeName;
            }
        }
        public string EmployeeDesignation
        {
            get
            {
                return _employeDesignation;
            }
        }
        public string ManagerId
        {
            get
            {
                return _managerId;
            }
        }
        public string DateOfJoin
        {
            get
            {
                return _dateOfJoin;
            }
        }
        public string Salary
        {
            get
            {
                return _salary;
            }
        }
        public string Comission
        {
            get
            {
                return _comission;
            }
        }
        public string DepartmentNumber
        {
            get
            {
                return _departmentNumber;
            }
        }

        
        public override bool Equals(object obj)
        {
            Employee employee;
            employee = (Employee)obj;
            if ((employee._employeId == this._employeId))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            return 1;
        }

    }
}
