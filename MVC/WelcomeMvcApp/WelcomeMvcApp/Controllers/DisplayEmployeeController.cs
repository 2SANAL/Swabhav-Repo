using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMvcApp.BusinessModel;
using WelcomeMvcApp.Servies;
using WelcomeMvcApp.Model.DisplayEmp;

namespace WelcomeMvcApp.Controllers

{
    public class DisplayEmployeeController : Controller
    {
        private readonly EmployeServies _servies = new EmployeServies();
        private readonly DisplayEmpViewModel _displayEmpViewModel = new DisplayEmpViewModel();

        // GET: DisplayEmployee
        [HttpGet]
        public ActionResult Index()
        {
            _servies.CreateDeptList();
            _servies.CreateEmployeeList();

            _displayEmpViewModel.EmployeList = _servies.EmployeeList;
            _displayEmpViewModel.DeptList = _servies.DepartmentsList;
            ViewBag.departments = _servies.DepartmentsList;

            return View(_displayEmpViewModel);
        }
        [HttpPost]
        public ActionResult Index(Department d)
        {
            ViewBag.departments = _servies.DepartmentsList;
            _displayEmpViewModel.EmployeList = _servies.GetDeptWisEmployees(d.DeptNo);
            _displayEmpViewModel.DeptList = _servies.DepartmentsList;
            return View(_displayEmpViewModel);
        }
    }
}