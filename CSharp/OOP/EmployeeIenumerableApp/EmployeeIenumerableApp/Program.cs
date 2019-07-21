using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeIenumerableApp
{
    class Program
    {
        private static IEnumerable<Employee> _employees;
        private static IEnumerable<Departments> _departmentses;
        static void Main(string[] args)
        {

            CreateEmpDetails();
            CreateDept();
            // GetCountOfDeptNoEmp();
            //  GetNoOfManager();
            //  GetNOEmpInDept();
            //GetDNameAndEname();
            // GetBossAndEmp();
            //  GetBossAndEmpAndDept();
            //  GetNullDept();
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
            //           GetMgrIsKingEmpNo();
            //  GetAgregates();
        }

        private static void GetNOEmpInDept()
        {
            var NOEmpInDept = _departmentses
                .Join(_employees,
                    dept => dept.DeptNo,
                    emp => emp.DEPTNO,
                    (departments, employee) => new
                    {
                        dept = departments.DeptName,
                        emp = employee.ENAME
                    })
                .GroupBy((g) => new { g.dept, g.emp });


            foreach (var e in NOEmpInDept)
            {
                Console.WriteLine(" " + e.Key.dept);
            }

        }
        private static void GetNoOfManager()
        {
            var managerCount = _employees
                .Where((m) => m.JOB.Equals("MANAGER") && m.DEPTNO.Equals(10))
                .GroupBy((g) => new { g.DEPTNO, g.JOB })
                .Select((m) => new { g = m.Key, c = m.Count() });

            foreach (var manager in managerCount)
            {
                Console.WriteLine(manager.c + " " + manager.g.DEPTNO + " " + manager.g.JOB);
            }
        }

        private static void GetCountOfDeptNoEmp()
        {
            var countOfDeptNo =
                from employee in _employees
                orderby employee.DEPTNO
                group employee by employee.DEPTNO
                into g
                select new { no = g.Key, de = g.Count() };

            foreach (var e in countOfDeptNo)
            {
                Console.WriteLine(e.de + " " + e.no);
            }

            Console.WriteLine("Job Wise Count");
            var countJobWise =
                from employee1 in _employees
                orderby employee1.JOB
                group employee1 by employee1.JOB
                into g
                select new { no = g.Key, job = g.Count() };

            foreach (var e in countJobWise)
            {
                Console.WriteLine(e.no + " " + e.job);
            }
        }
        private static void GetBossAndEmpAndDept()
        {
            var deptEmapMgr = _employees.Join(_employees,
                emp1 => emp1.MGR,
                emp2 => emp2.EMPNO,
                (emp1, emp2) => new
                {
                    BossName = emp1.ENAME,
                    ENAme = emp2.ENAME,
                    EDept = emp2.DEPTNO
                }
            );

            var innerjoin = deptEmapMgr.Join(
                _departmentses,
                d => d.EDept,
                e => e.DeptNo,

                (emp1, emp2) => new
                {
                    BossName = emp1.BossName,
                    DName = emp2.DeptName,
                    EName = emp1.ENAme
                }

            );


            foreach (var data in innerjoin)
            {
                Console.WriteLine("Emap NAme :" + data.BossName + " BossName :" + data.EName + " Dept name:" + data.DName);
            }
        }

        private static void GetBossAndEmp()
        {
            var innerjoin = _employees.Join(_employees,
                emp1 => emp1.MGR,
                emp2 => emp2.EMPNO,
                (emp1, emp2) => new
                {
                    BossName = emp1.ENAME,
                    ENAme = emp2.ENAME
                }
            );

            foreach (var data in innerjoin)
            {
                Console.WriteLine("Emap NAme :" + data.BossName + " BossName :" + data.ENAme);
            }
        }
        private static void GetNullDept()
        {
            var NullDept = from d in _departmentses
                           join e in _employees.Where(o => o.EMPNO.Equals(null))
                    on d.DeptNo equals e.EMPNO into g
                           select new
                           {
                               dno = d.DeptNo,
                               dname = d.DeptName,
                               dlocation = d.DeptLocation
                           };

            foreach (var data in NullDept)
            {
                Console.WriteLine("dname :" + data.dname + " DNo :" + data.dno + " lo :" + data.dlocation);
            }
        }

        private static void GetDNameAndEname()
        {
            var innerjoin = _employees.Join(_departmentses,
                emp => emp.DEPTNO,
                dept => dept.DeptNo,
                (emp, dept) => new
                {
                    empName = emp.ENAME,
                    depNAme = dept.DeptName
                }
            );

            foreach (var data in innerjoin)
            {
                Console.WriteLine("Ename :" + data.empName + " DName :" + data.depNAme);
            }
        }


        private static void CreateDept()
        {
            Departments dept1 = new Departments()
            {
                DeptName = "ACCOUNTING",
                DeptLocation = "NEW YORK",
                DeptNo = 10
            };
            Departments dept2 = new Departments()
            {
                DeptName = "RESEARCH",
                DeptLocation = "DALLAS",
                DeptNo = 20
            };
            Departments dept3 = new Departments()
            {
                DeptName = "SALES",
                DeptLocation = "CHICAGO",
                DeptNo = 30
            };
            Departments dept4 = new Departments()
            {
                DeptName = "OPERATIONS",
                DeptLocation = "BOSTON",
                DeptNo = 40
            };
            _departmentses = new List<Departments>() { dept1, dept2, dept3, dept4 };
        }
        private static void CreateEmpDetails()
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
            _employees = new List<Employee>()
                { employee1,employee2,employee3,employee4,employee5,employee6,employee7,employee8,employee9,
                    employee10,employee11,employee12,employee13,employee14};
        }
        private static void GetAgregates()
        {
            var totalEmp = _employees.Count();
            Console.WriteLine("Avrage salary :" + _employees.Average((m) => m.SAL));
            Console.WriteLine("MAx Salary :" + _employees.Max((m) => m.SAL));
            Console.WriteLine("Min Salary :" + _employees.Min((m) => m.SAL));
            Console.WriteLine("Total Count :" + totalEmp);
        }
        private static void GetNameAndCommAndTotalSal()
        {
            var empNameAndCommAndTotalSal =
                _employees
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
                _employees.Distinct()
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
                _employees
                    .OrderByDescending((emp) => emp.JOB)
                    .Take(3);
            DisplayData(empTop3);
        }

        private static void GetEmpDeptNoIsScott()
        {
            var empIsScott =
                _employees
                    .Where((emp) => emp.ENAME.Equals("SCOTT"))
                    .Select((emp) => new { emp.DEPTNO });
            double deptNo = 0;
            foreach (var emp in empIsScott)
            {
                deptNo = emp.DEPTNO;
            }

            IEnumerable<Employee> getEmp =
                _employees
                    .Where((s) => s.DEPTNO == deptNo);
            DisplayData(getEmp);

        }

        private static void GetAllEmpJobSameAsBLAKE()
        {
            var empIsBlake =
                _employees
                    .Where((emp) => emp.ENAME.Equals("BLAKE"))
                    .Select((emp) => new { emp.JOB });
            string job = "";
            foreach (var emp in empIsBlake)
            {
                job = emp.JOB;
            }

            IEnumerable<Employee> getEmp =
                _employees
                    .Where((s) => s.JOB.Equals(job));
            DisplayData(getEmp);
        }

        private static void GetMgrIsKingEmpNo()
        {
            var empIsBlake =
                _employees
                    .Where((emp) => emp.ENAME.Equals("KING"))
                    .Select((emp) => new { emp.EMPNO });
            double empNo = 0;
            foreach (var emp in empIsBlake)
            {
                empNo = emp.EMPNO;
            }

            IEnumerable<Employee> getEmp =
                _employees
                    .Where((s) => s.MGR == empNo);
            DisplayData(getEmp);
        }

        private static void GetYearOfExp()
        {
            var empNameHDateExp =
                _employees
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
                _employees
                    .Select((emp) => new { Name = emp.ENAME.ToLower() });
            foreach (var EName in empLowerCaseEmpName)
            {
                Console.WriteLine("Emp Name :" + EName.Name);
            }
        }

        private static void GetEmployeeOrderByAsc()
        {
            IEnumerable<Employee> empOrderByNameAsc =
                _employees
                    .OrderBy((emp) => emp.ENAME);
            DisplayData(empOrderByNameAsc);
        }

        private static void GetEmpSalBetween5000And2000()
        {
            IEnumerable<Employee> employeesSalBetween5000And2000 =
                _employees
                    .Where((emp) => emp.SAL < 5000 && emp.SAL > 2000);
            DisplayData(employeesSalBetween5000And2000);
        }

        private static void GetEmpDeptNo10Or20()
        {
            IEnumerable<Employee> employeesDeptNo10Or20 =
                _employees
                    .Where((emp) => emp.DEPTNO == 10 || emp.DEPTNO == 20);
            DisplayData(employeesDeptNo10Or20);
        }

        private static void GetEmpJobIsManager()
        {
            var employeesJobIsManager =
                 _employees
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
                _employees
                    .Where((emp) => emp.DEPTNO == 10 && emp.JOB.Equals("MANAGER"));
            DisplayData(employeesDeptIs10AndJobManager);
        }

        private static void GetEmpCommIsNull()
        {
            IEnumerable<Employee> employeesCommIsNull =
                _employees
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
