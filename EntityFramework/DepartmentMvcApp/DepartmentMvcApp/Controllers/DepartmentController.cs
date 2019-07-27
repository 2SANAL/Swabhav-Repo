using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using DepartmentMvcApp.BusinessModel;
using DepartmentMvcApp.Model;
using DepartmentMvcApp.Servies;

namespace DepartmentMvcApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServies _department;
        private readonly LoginServies _login;
        private readonly IndexViewModel _indexViewModel;

        // GET: Department
        public DepartmentController(IDepartmentServies department)
        {
            _department = department;
            _login = new LoginServies();
            _indexViewModel = new IndexViewModel();
        }

        public ActionResult Index()
        {
            _indexViewModel.Departments = _department.GetDepatDepartments().ToList();
            _indexViewModel.Count = _indexViewModel.Departments.Count;
            return View(_indexViewModel);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Add()
        {
            AddViewModel addViewModel = new AddViewModel();
            return View(addViewModel);
        }

        [HttpPost]
        public ActionResult Add(AddViewModel addViewModel)
        {
            _department.AddDepartments(_department.ConvertToDeptObj(addViewModel));
            return RedirectToAction("Index");
        }
    
        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            EditViewModel editViewModel = new EditViewModel();
            Department department;
            department = _department.GetDeptById(id);

            editViewModel.Id = id;
            editViewModel.DepartmentName = department.DepartmentName;
            editViewModel.Location = department.Location;

            return View(editViewModel);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel editViewModel)
        {
            _department.Update(editViewModel);
            return RedirectToAction("Index", "Department");
        }
        
        [HttpGet]
        public ActionResult Login()
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            return View(loginViewModel);

        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            bool isValid = _login.IsValidUser(loginViewModel);
            if (isValid.Equals(true))
            {
                FormsAuthentication.SetAuthCookie(loginViewModel.Username, false);
                return RedirectToAction("Index", "Department");
            }
            else
            {
                return RedirectToAction("Login", "Department");
            }

        }
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Department");
        }

    }
}