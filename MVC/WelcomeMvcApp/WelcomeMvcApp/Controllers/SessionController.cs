using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;


namespace WelcomeMvcApp.Controllers
{
    [SessionState(SessionStateBehavior.Default)]
    public class SessionController : Controller
    {
        private static int value;
        // GET: Session

        public ActionResult Index()
        {
            if (Session["Counter"] == null)
            {
                Session["Counter"] = value;
                ViewBag.newData = Session["Counter"];
                ViewBag.id = Session.SessionID;
            }
            else
            {
                Session["Counter"] = value;
                ViewBag.newData = Session["Counter"];
                ViewBag.old = Convert.ToInt32(ViewBag.newData) - 1;
            }
            value++;
            return View();
        }

    }


}