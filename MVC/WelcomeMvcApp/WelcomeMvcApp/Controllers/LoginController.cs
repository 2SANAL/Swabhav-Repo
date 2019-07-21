using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMvcApp.Model.Student;
using  WelcomeMvcApp.Servies;

namespace WelcomeMvcApp.Controllers
{
    public class LoginController : Controller
    {
        private string _username = "akash";

        private string _password = "123";
        // GET: Login
        public ActionResult Index()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel loginViewModel)
        {
            Authentrication a=new Authentrication();
            bool flag = a.Authenticate(loginViewModel);

            if (flag==true)
            {
                Session["login"] = 1;
                return RedirectToAction("Index","Student");
            }
            else
            {
                return View(loginViewModel);
            }
        }
    }
}