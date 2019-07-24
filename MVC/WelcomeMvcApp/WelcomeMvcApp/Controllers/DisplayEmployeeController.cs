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
        private readonly EmployeServies _servies;
        private readonly DisplayEmpViewModel _displayEmpViewModel;


        public DisplayEmployeeController()
        {
            _servies = new EmployeServies();
            _displayEmpViewModel = new DisplayEmpViewModel();
        }
        // GET: DisplayEmployee
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.departments = _servies.CreateDeptList();
            _displayEmpViewModel.EmployeList = _servies.CreateEmployeeList();
            _displayEmpViewModel.DeptList = ViewBag.departments;
            ViewBag.departments = _displayEmpViewModel.DeptList;

            return View(_displayEmpViewModel);
        }
        [HttpPost]
        public ActionResult Index(DisplayEmpViewModel deDisplayEmpViewModel)
        {
            _servies.CreateEmployeeList();
            ViewBag.departments = _servies.CreateDeptList();
            _displayEmpViewModel.EmployeList = _servies.GetDeptWisEmployees(deDisplayEmpViewModel.DepaTNO);
            _displayEmpViewModel.DeptList = ViewBag.departments;
            return View(_displayEmpViewModel);
        }
    }
}