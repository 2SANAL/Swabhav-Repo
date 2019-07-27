using System;
using System.Linq;
using System.Web.Mvc;
using DepartmentMvcApp.BusinessModel;
using DepartmentMvcApp.Filter;
using DepartmentMvcApp.Servies;
using DepartmentMvcApp.Model;
using DepartmentMvcApp.Repository;
using PagedList;

namespace DepartmentMvcApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeServies _employee;
        private readonly DepartmentServies _department;
        private readonly EmployeeViewModel _employeeViewModel;
        private readonly DepartmentRepository _departmentRepository;
        private int count = 0;
        public EmployeeController()
        {
            _employee = new EmployeeServies();
            _department = new DepartmentServies();
            _employeeViewModel = new EmployeeViewModel();
            _departmentRepository = new DepartmentRepository();
        }
        // GET: Employee

        public ActionResult Index(Guid id)
        {

            _employeeViewModel.Employees = _employee.GetEmployeesByDeptId(id).ToList();
            _employeeViewModel.Count = _employeeViewModel.Employees.Count;
            return View(_employeeViewModel);
        }

        [HttpGet]
        public ActionResult Add()
        {
            AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel();
            addEmployeeViewModel.Departments = _department.GetDepatDepartments().ToList();
            return View(addEmployeeViewModel);
        }
   
        [HttpPost]
        public ActionResult Add(AddEmployeeViewModel addEmployeeViewModel)
        {
            _employee.AddEmployee(_employee.GetEployeeObj(addEmployeeViewModel));
            return RedirectToAction("EmployeDetails", "Employee");
        }
   
        [HttpGet]
        public ActionResult EmployeDetails()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.Employees = _departmentRepository.GetOnlye10Emp().OfType<Employee>().ToList();
            employeeViewModel.Count = employeeViewModel.Employees.Count;
            return View(employeeViewModel);
        }
   
        [HttpGet]
        public ActionResult EditEmployee(Guid id)
        {
            var emp = _employee.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult EditEmployee(EditEmployeeViewModel editEmployeeViewModel)
        {
            _employee.UpdateEmp(editEmployeeViewModel);
            return RedirectToAction("EmployeDetails", "Employee");
        }

        [HttpPost]
        public ActionResult EmployeDetails(FormCollection form)
        {
            if (form["txtSearch"] != null)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.Employees = _employee.GetEmployeesByName(form["txtSearch"]).ToList();
                employeeViewModel.Count = employeeViewModel.Employees.Count;
                return View(employeeViewModel);
            }
            Console.WriteLine("");
            return RedirectToAction("EmployeDetails", "Employee");
        }
    }
}