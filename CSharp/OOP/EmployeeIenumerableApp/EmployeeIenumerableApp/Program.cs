using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeIenumerableApp
{
    class Program
    {
        private static IEnumerable<Employee> employees;
        private static List<double> deptList = new List<double>();
        static void Main(string[] args)
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
            employees = new List<Employee>()
                { employee1,employee2,employee3,employee4,employee5,employee6,employee7,employee8,employee9,
                    employee10,employee11,employee12,employee13,employee14};


            // GetEmployeeOrderByAsc();
            //GetEmpSalBetween5000And2000();
            // GetEmpDeptNo10Or20();
            //   GetEmpJobIsManager();
            // GetEmpDeptIs10AndJobManager();
            //   GetEmpCommIsNull();
            //  GetLowerCaseEmpName();
            // GetNameAndCommAndTotalSal();
            //    GetDestingDeptNo();
            //GetYearOfExp();
            // GetEmpDeptNoIsScott();
           // GetAllEmpJobSameAsBLAKE();
           GetMgrIsKingEmpNo();
        }

        private static void GetNameAndCommAndTotalSal()
        {
            var empNameAndCommAndTotalSal =
                employees
                    .Select((emp) => new { emp.ENAME, emp.COMM, CTC = (emp.SAL * 12 + emp.DEPTNO) });
            Console.WriteLine("Name\tComm\tTotalSal");
            foreach (var emp in empNameAndCommAndTotalSal)
            {
                Console.WriteLine(emp.ENAME + "\t" + emp.COMM + "\t" + (emp.CTC));
            }
        }

        private static void GetDestingDeptNo()
        {
            var empDeptNo =
                employees.Distinct()
                    .Select((emp) => new { emp.DEPTNO });
            var DistNemp = empDeptNo.AsQueryable().Distinct();

            foreach (var nunber in DistNemp)
            {
                Console.WriteLine("Dept No" + nunber.DEPTNO);
            }
        }

        private static void GetTop3()
        {
            IEnumerable<Employee> empTop3 =
                employees
                    .OrderByDescending((emp) => emp.JOB)
                    .Take(3);
            DisplayData(empTop3);
        }

        private static void GetEmpDeptNoIsScott()
        {
            var empIsScott =
                employees
                    .Where((emp) => emp.ENAME.Equals("SCOTT"))
                    .Select((emp) => new { emp.DEPTNO });
            double deptNo = 0;
            foreach (var emp in empIsScott)
            {
                deptNo = emp.DEPTNO;
            }

            IEnumerable<Employee> getEmp =
                employees
                    .Where((s) => s.DEPTNO == deptNo);
            DisplayData(getEmp);

        }

        private static void GetAllEmpJobSameAsBLAKE()
        {
            var empIsBlake =
                employees
                    .Where((emp) => emp.ENAME.Equals("BLAKE"))
                    .Select((emp) => new { emp.JOB });
            string job = "";
            foreach (var emp in empIsBlake)
            {
                job = emp.JOB;
            }

            IEnumerable<Employee> getEmp =
                employees
                    .Where((s) => s.JOB.Equals(job));
            DisplayData(getEmp);
        }

        private static void GetMgrIsKingEmpNo()
        {
            var empIsBlake =
                employees
                    .Where((emp) => emp.ENAME.Equals("KING"))
                    .Select((emp) => new { emp.EMPNO });
            double empNo=0 ;
            foreach (var emp in empIsBlake)
            {
                empNo = emp.EMPNO;
            }

            IEnumerable<Employee> getEmp =
                employees
                    .Where((s) => s.MGR==empNo);
            DisplayData(getEmp);
        }

        private static void GetYearOfExp()
        {
            var empNameHDateExp =
                employees
                    .Select((emp) => new
                    { emp.ENAME, emp.HIREDATE, YearOfExpe = (DateTime.Now.Year - Convert.ToDateTime(emp.HIREDATE).Year) });

            foreach (var emp in empNameHDateExp)
            {
                Console.WriteLine("Name :" + emp.ENAME + " HDate :" + emp.HIREDATE + " Year OF  Exp :" + emp.YearOfExpe);
            }
        }


        private static void GetLowerCaseEmpName()
        {
            var empLowerCaseEmpName =
                employees
                    .Select((emp) => new { Name = emp.ENAME.ToLower() });
            foreach (var EName in empLowerCaseEmpName)
            {
                Console.WriteLine("Emp Name :" + EName.Name);
            }
        }

        private static void GetEmployeeOrderByAsc()
        {
            IEnumerable<Employee> empOrderByNameAsc =
                employees
                    .OrderBy((emp) => emp.ENAME);
            DisplayData(empOrderByNameAsc);
        }

        private static void GetEmpSalBetween5000And2000()
        {
            IEnumerable<Employee> employeesSalBetween5000And2000 =
                employees
                    .Where((emp) => emp.SAL < 5000 && emp.SAL > 2000);
            DisplayData(employeesSalBetween5000And2000);
        }

        private static void GetEmpDeptNo10Or20()
        {
            IEnumerable<Employee> employeesDeptNo10Or20 =
                employees
                    .Where((emp) => emp.DEPTNO == 10 || emp.DEPTNO == 20);
            DisplayData(employeesDeptNo10Or20);
        }

        private static void GetEmpJobIsManager()
        {
            var employeesJobIsManager =
                 employees
                     .Where((emp) => emp.JOB.Equals("MANAGER"))
                     .Select((employee) => new { employee.ENAME });

            foreach (var empName in employeesJobIsManager)
            {
                Console.WriteLine("Employee Name :" + empName.ENAME);
            }
        }

        private static void GetEmpDeptIs10AndJobManager()
        {
            IEnumerable<Employee> employeesDeptIs10AndJobManager =
                employees
                    .Where((emp) => emp.DEPTNO == 10 && emp.JOB.Equals("MANAGER"));
            DisplayData(employeesDeptIs10AndJobManager);
        }

        private static void GetEmpCommIsNull()
        {
            IEnumerable<Employee> employeesCommIsNull =
                employees
                    .Where((emp) => emp.COMM == 0);
            DisplayData(employeesCommIsNull);
        }

        private static void DisplayData(IEnumerable<Employee> employeesList)
        {
            foreach (Employee employee in employeesList)
            {
                Console.Write("EmpNo :" + employee.EMPNO + " Emp Name :" + employee.ENAME + " Job :"
                              + employee.JOB + " MGR :" + employee.MGR + " HIREDATE :" + employee.HIREDATE
                              + "  Salary :" + employee.SAL + " Comm :" + employee.COMM + " DeptNo :"
                              + employee.DEPTNO + "\n");

            }
        }


    }
}
