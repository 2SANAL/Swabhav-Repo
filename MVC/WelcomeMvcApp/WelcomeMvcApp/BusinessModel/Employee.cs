using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMvcApp.BusinessModel
{
    public class Employee
    {
        public int EMPNO { get; set; }
        public string ENAME { get; set; }
        public string JOB { get; set; }
        public int MGR { get; set; }
        public string HIREDATE { get; set; }
        public double SAL { get; set; }
        public double COMM { get; set; }
        public double DEPTNO { get; set; }
    }
}