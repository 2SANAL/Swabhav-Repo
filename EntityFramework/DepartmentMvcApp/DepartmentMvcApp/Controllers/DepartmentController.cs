using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using DepartmentMvcApp.BusinessModel;
using DepartmentMvcApp.Model;
using DepartmentMvcApp.Repository;
using DepartmentMvcApp.Servies;

namespace DepartmentMvcApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentServies _servies = new DepartmentServies();
        private readonly LoginServies _loginServies = new LoginServies();
        private readonly IndexViewModel _indexViewModel = new IndexViewModel();

        // GET: Department
        
        public ActionResult Index()
        {
            _indexViewModel.Departments = _servies.GetDepatDepartments().ToList();
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
            _servies.AddDepartments(_servies.ConvertToDeptObj(addViewModel));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            EditViewModel editViewModel = new EditViewModel();
            Department dept = new Department();
            dept = _servies.GetDeptById(id);

            editViewModel.Id = id;
            editViewModel.DepartmentName = dept.DepartmentName;
            editViewModel.Location = dept.Location;

            return View(editViewModel);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel editViewModel)
        {
            _servies.Update(editViewModel);
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
            bool isValid = _loginServies.IsValidUser(loginViewModel);
            if (isValid == true)
            {
                FormsAuthentication.SetAuthCookie(loginViewModel.Username, false);
                return RedirectToAction("Index", "Department");
            }
            else
            {
                return RedirectToAction("Login", "Department");
            }

        }
    }
}