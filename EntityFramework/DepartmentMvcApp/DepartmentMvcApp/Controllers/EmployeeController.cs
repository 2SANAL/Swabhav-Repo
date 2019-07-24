using System;
using System.Linq;
using System.Web.Mvc;
using DepartmentMvcApp.Servies;
using DepartmentMvcApp.Model;

namespace DepartmentMvcApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeServies _employeeServies = new EmployeeServies();
        private readonly DepartmentServies _departmentServies = new DepartmentServies();
        private readonly EmployeeViewModel _employeeViewModel = new EmployeeViewModel();

        // GET: Employee
        public ActionResult Index(Guid id)
        {

            _employeeViewModel.Employees = _employeeServies.GetEmployeesByDeptId(id).ToList();
            _employeeViewModel.Count = _employeeViewModel.Employees.Count;
            return View(_employeeViewModel);
        }

        [HttpGet]
        public ActionResult Add()
        {
            AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel();
            addEmployeeViewModel.Departments = _departmentServies.GetDepatDepartments().ToList();
            return View(addEmployeeViewModel);
        }

        [HttpPost]
        public ActionResult Add(AddEmployeeViewModel addEmployeeViewModel)
        {
            _employeeServies.AddEmployee(_employeeServies.GetEployeeObj(addEmployeeViewModel));
            return RedirectToAction("EmployeDetails", "Employee");
        }

        [HttpGet]
        public ActionResult EmployeDetails()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.Employees = _employeeServies.GetEmployees().ToList();
            employeeViewModel.Count = employeeViewModel.Employees.Count;
            return View(employeeViewModel);
        }

    }
}