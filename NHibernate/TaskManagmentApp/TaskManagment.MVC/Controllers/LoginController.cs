using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagment.Core.Services;
using System.Web.Mvc;
using TaskManagment.MVC.Model;

namespace TaskManagment.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserService _userService;

        public LoginController()
        {
            _userService = new UserService();
        }
        // GET: Login
        public ActionResult Index()
        {
            LoginViewModel loginView = new LoginViewModel();
            return View(loginView);
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel loginViewModel)
        {
            bool login = _userService.Loginvalidation(loginViewModel.UserId, loginViewModel.Password);
            if (login == true)
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                loginViewModel.Message = "Please enter valid Userid  and Password";
                return View(loginViewModel);
            }
        }
    }
}