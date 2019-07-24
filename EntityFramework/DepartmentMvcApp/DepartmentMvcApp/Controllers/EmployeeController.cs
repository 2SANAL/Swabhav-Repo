using System;
using System.Linq;
using System.Web.Mvc;
using DepartmentMvcApp.Filter;
using DepartmentMvcApp.Servies;
using DepartmentMvcApp.Model;
using PagedList;
using DepartmentMvcApp.BusinessModel;

namespace DepartmentMvcApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeServies _employee;
        private readonly DepartmentServies _department;
        private readonly EmployeeViewModel _employeeViewModel;


        public EmployeeController()
        {
            _employee = new EmployeeServies();
            _department = new DepartmentServies();
            _employeeViewModel = new EmployeeViewModel();
        }
        // GET: Employee
        [LoggerFilter]
        public ActionResult Index(Guid id)
        {

            _employeeViewModel.Employees = _employee.GetEmployeesByDeptId(id).ToList();
            _employeeViewModel.Count = _employeeViewModel.Employees.Count;
            return View(_employeeViewModel);
        }
        [LoggerFilter]
        [HttpGet]
        public ActionResult Add()
        {
            AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel();
            addEmployeeViewModel.Departments = _department.GetDepatDepartments().ToList();
            return View(addEmployeeViewModel);
        }
        [LoggerFilter]
        [HttpPost]
        public ActionResult Add(AddEmployeeViewModel addEmployeeViewModel)
        {
            _employee.AddEmployee(_employee.GetEployeeObj(addEmployeeViewModel));
            return RedirectToAction("EmployeDetails", "Employee");
        }
        [LoggerFilter]
        [HttpGet]
        public ActionResult EmployeDetails(int? page)
        {
            int pageSize = 5;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            IPagedList<Employee> employees = null;

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.Employees = _employee.GetEmployees().ToList();
            employeeViewModel.Count = employeeViewModel.Employees.Count;

            employees = employeeViewModel.Employees.ToPagedList(pageIndex, pageSize);
            return View(employees);
        }
        [LoggerFilter]
        [HttpGet]
        public ActionResult EditEmployee(Guid id)
        {
            var emp = _employee.GetEmployeeById(id);
            return View(emp);
        }
        [LoggerFilter]
        [HttpPost]
        public ActionResult EditEmployee(EditEmployeeViewModel editEmployeeViewModel)
        {
            _employee.UpdateEmp(editEmployeeViewModel);
            return RedirectToAction("EmployeDetails", "Employee");
        }
    }
}