using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMvcApp.Controllers
{
    public class SummaryController : Controller
    {
        // GET: Summary
        public ActionResult Index()
        {
            ViewBag.session = Session["Counter"];
            ViewBag.application = HttpContext.Application["Counter"];
            return View();
        }
    }
}