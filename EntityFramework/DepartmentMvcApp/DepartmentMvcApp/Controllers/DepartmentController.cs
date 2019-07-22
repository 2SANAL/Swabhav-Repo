using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DepartmentMvcApp.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return RedirectToAction("Add");
        }
    }
}