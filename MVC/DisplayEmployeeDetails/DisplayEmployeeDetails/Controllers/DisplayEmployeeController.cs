using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DisplayEmployeeDetails.BusinessModel;
using DisplayEmployeeDetails.Model;
using DisplayEmployeeDetails.Servies;

namespace DisplayEmployeeDetails.Controllers
{
    public class DisplayEmployeeController : Controller
    {
        private readonly EmployeServies _servies = new EmployeServies();
        private readonly IndexViewModel _indexViewModel = new IndexViewModel();

        // GET: DisplayEmployee
        public ActionResult Index()
        {
            _servies.CreateDeptList();
            _servies.CreateEmployeeList();

            _indexViewModel.EmployeList = _servies.EmployeeList;
            _indexViewModel.DeptList = _servies.DepartmentsList;
            ViewBag.departments = _servies.DepartmentsList;

            return View(_indexViewModel);
        }
        [HttpPost]
        public ActionResult Index(Department i)
        {
            _indexViewModel.EmployeList = _servies.GetDeptWisEmployees(i.DeptNo);
            _indexViewModel.DeptList = _servies.DepartmentsList;
            return View(_indexViewModel);
        }
    }
}