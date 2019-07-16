using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Test()
        {
            return "<h1>Welcome To MVC test </h1>";
        }

        public ContentResult Content()
        {
            return Content("<H1>Return Some string content</h1>");
        }

        public ActionResult Index(string name)
        {
            if (name == null)
            {
                return View();
            }
            return Content("developer =" + name);
        }
    }
}