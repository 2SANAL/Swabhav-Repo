using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMvcApp.BusinessModel;

namespace WelcomeMvcApp.Servies
{
    public class EmployeServies
    {
        private List<Employee> _employeesList = new List<Employee>();
        private List<Department> _departmentsList = new List<Department>();

        public List<Employee> EmployeeList
        {
            get { return _employeesList; }
        }

        public List<Department> DepartmentsList
        {
            get { return _departmentsList; }
        }

        public void CreateEmployeeList()
        {
            Employee employee1 = new Employee()
            {
                EMPNO = 7839,
                ENAME = "KING",
                JOB = "PRESIDENT",
                MGR = 0,
                HIREDATE = "17-NOV-81",
                SAL = 5000,
                COMM = 0,
                DEPTNO = 10
            };
            Employee employee2 = new Employee()
            {

                EMPNO = 7698,
                ENAME = "BLAKE",
                JOB = "MANAGER",
                MGR = 7839,
                HIREDATE = "1-MAY-81",
                SAL = 2850,
                COMM = 0,
                DEPTNO = 30
            };
            Employee employee3 = new Employee()
            {
                EMPNO = 7782,
                ENAME = "CLARK",
                JOB = "MANAGER",
                MGR = 7839,
                HIREDATE = "9-JUN-81",
                SAL = 2450,
                COMM = 0,
                DEPTNO = 10
            };
            Employee employee4 = new Employee()
            {
                EMPNO = 7566,
                ENAME = "JONES",
                JOB = "MANAGER",
                MGR = 7839,
                HIREDATE = "2-APR-81",
                SAL = 2975,
                COMM = 0,
                DEPTNO = 20
            };
            Employee employee5 = new Employee()
            {
                EMPNO = 7654,
                ENAME = "MARTIN",
                JOB = "SALESMAN",
                MGR = 7698,
                HIREDATE = "28-SEP-81",
                SAL = 1250,
                COMM = 1400,
                DEPTNO = 30
            };
            Employee employee6 = new Employee()
            {
                EMPNO = 7499,
                ENAME = "ALLEN",
                JOB = "SALESMAN",
                MGR = 7698,
                HIREDATE = "20-FEB-81",
                SAL = 1600,
                COMM = 300,
                DEPTNO = 30
            };
            Employee employee7 = new Employee()
            {
                EMPNO = 7844,
                ENAME = "TURNER",
                JOB = "SALESMAN",
                MGR = 7698,
                HIREDATE = "8-SEP-81",
                SAL = 1500,
                COMM = 0,
                DEPTNO = 30
            };
            Employee employee8 = new Employee()
            {
                EMPNO = 7900,
                ENAME = "JAMES",
                JOB = "CLERK",
                MGR = 7698,
                HIREDATE = "3-DEC-81",
                SAL = 950,
                COMM = 0,
                DEPTNO = 30
            };
            Employee employee9 = new Employee()
            {
                EMPNO = 7521,
                ENAME = "WARD",
                JOB = "SALESMAN",
                MGR = 7698,
                HIREDATE = "22-FEB-81",
                SAL = 1250,
                COMM = 500,
                DEPTNO = 30
            }; Employee employee10 = new Employee()
            {
                EMPNO = 7902,
                ENAME = "FORD",
                JOB = "ANALYST",
                MGR = 7566,
                HIREDATE = "3-DEC-81",
                SAL = 3000,
                COMM = 0,
                DEPTNO = 20
            }; Employee employee11 = new Employee()
            {
                EMPNO = 7369,
                ENAME = "SMITH",
                JOB = "CLERK",
                MGR = 7902,
                HIREDATE = "17-DEC-80",
                SAL = 800,
                COMM = 0,
                DEPTNO = 20
            }; Employee employee12 = new Employee()
            {
                EMPNO = 7788,
                ENAME = "SCOTT",
                JOB = "ANALYST",
                MGR = 7566,
                HIREDATE = "09-DEC-82",
                SAL = 3000,
                COMM = 0,
                DEPTNO = 20
            }; Employee employee13 = new Employee()
            {
                EMPNO = 7876,
                ENAME = "ADAMS",
                JOB = "CLERK",
                MGR = 7788,
                HIREDATE = "12-JAN-83",
                SAL = 1100,
                COMM = 0,
                DEPTNO = 20
            }; Employee employee14 = new Employee()
            {
                EMPNO = 7934,
                ENAME = "MILLER",
                JOB = "CLERK",
                MGR = 7782,
                HIREDATE = "23-JAN-82",
                SAL = 1300,
                COMM = 0,
                DEPTNO = 10
            };
            _employeesList = new List<Employee>()
                { employee1,employee2,employee3,employee4,employee5,employee6,employee7,employee8,employee9,
                    employee10,employee11,employee12,employee13,employee14};
        }

        public void CreateDeptList()
        {
            Department dept1 = new Department()
            {
                DeptName = "ACCOUNTING",
                DeptLocation = "NEW YORK",
                DeptNo = 10
            };
            Department dept2 = new Department()
            {
                DeptName = "RESEARCH",
                DeptLocation = "DALLAS",
                DeptNo = 20
            };
            Department dept3 = new Department()
            {
                DeptName = "SALES",
                DeptLocation = "CHICAGO",
                DeptNo = 30
            };
            Department dept4 = new Department()
            {
                DeptName = "OPERATIONS",
                DeptLocation = "BOSTON",
                DeptNo = 40
            };
            _departmentsList = new List<Department>() { dept1, dept2, dept3, dept4 };
        }


        public List<Employee> GetDeptWisEmployees(int deptNo)
        {
            List<Employee> newList = new List<Employee>();
            CreateEmployeeList();
            CreateDeptList();
            foreach (var employee in _employeesList)
            {
                if (employee.DEPTNO == deptNo)
                {
                    newList.Add(employee);
                }
            }

            return newList;
        }
    }
}