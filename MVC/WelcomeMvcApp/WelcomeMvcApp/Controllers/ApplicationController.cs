using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WelcomeMvcApp.Controllers
{
    public class ApplicationController : Controller
    {
        private static int value;
        // GET: Application
        public ActionResult Index()
        {
            if (HttpContext.Application["Counter"] == null)
            {
                HttpContext.Application["Counter"] = value;
                ViewBag.newData = HttpContext.Application["Counter"];
            }
            else
            {
                ViewBag.old = value - 1;
                HttpContext.Application["Counter"] = value;
                ViewBag.newData = HttpContext.Application["Counter"];
            }

            value++;
            return View();
        }
    }
}