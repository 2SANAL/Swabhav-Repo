using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMvcApp.Model;
using WelcomeMvcApp.Model.Registration;

namespace WelcomeMvcApp.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            return View(registrationViewModel);
        }

        [HttpPost]
        public ActionResult Index(RegistrationViewModel registrationViewModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.name = registrationViewModel.Name;
                ViewBag.age = registrationViewModel.Age;
                ViewBag.salary = registrationViewModel.Salary;
                ViewBag.email = registrationViewModel.Email;

                registrationViewModel.Message ="Successfully Registration";
                return View(registrationViewModel);
            }
            return View(registrationViewModel);

        }
    }
}