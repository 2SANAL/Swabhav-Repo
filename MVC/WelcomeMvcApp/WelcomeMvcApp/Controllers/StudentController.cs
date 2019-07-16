using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMvcApp.Model.Student;
using WelcomeMvcApp.Servies;

namespace WelcomeMvcApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            IndexViewModel indexViewModel=new IndexViewModel();
            StudentServies studentServies=new StudentServies();
            indexViewModel.Students = studentServies.Get();
            indexViewModel.Count = studentServies.Count;
            return View(indexViewModel);
        }
    }
}