using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MvcInternalizationApp.Model;

namespace MvcInternalizationApp.Controllers
{
    public class RegistrationController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            if (Session["CurrentCulture"] != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(Session["CurrentCulture"].ToString());
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Session["CurrentCulture"].ToString());
            }
        }


        // GET: Registration
        public ActionResult Index()
        {
            RegirationViewModel regirationViewModel = new RegirationViewModel();
            return View(regirationViewModel);
        }

        [HttpPost]
        public ActionResult Index(string ddlCulture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(ddlCulture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ddlCulture);

            Session["CurrentCulture"] = ddlCulture;
            return View("Index");
            if (ModelState.IsValid)
            {

            }

            return View();
        }
    }
}