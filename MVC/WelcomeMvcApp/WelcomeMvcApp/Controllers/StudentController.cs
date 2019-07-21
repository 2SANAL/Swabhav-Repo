using System;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WelcomeMvcApp.BusinessModel;
using WelcomeMvcApp.Model.Student;
using WelcomeMvcApp.Servies;
using WelcomeMvcApp.Repository;

namespace WelcomeMvcApp.Controllers
{
    public class StudentController : Controller
    {

        StudentServies studentServies = new StudentServies();
        private IndexViewModel _indexViewModel = new IndexViewModel();
        private StudentRepository _studentRepository = new StudentRepository();
        private static int _rollno;

        // GET: Student
        public ActionResult Index()
        {
            _indexViewModel.Students = _studentRepository.GetStudents();
            _indexViewModel.Count =_studentRepository.Count;
            return View(_indexViewModel);
        }

        [HttpGet]
        public ActionResult Add()
        {
            if (Convert.ToInt32(Session["login"]) == 1)
            {
                AddViewModel addViewModel = new AddViewModel();
                return View(addViewModel);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }

        [HttpPost]
        public ActionResult Add(AddViewModel addViewModel)
        {
            if (string.IsNullOrEmpty(addViewModel.StudentName) || string.IsNullOrEmpty(addViewModel.StudentDOB) ||
                string.IsNullOrEmpty(addViewModel.StudentGgpi) || string.IsNullOrEmpty(addViewModel.StudentLocation) ||
                string.IsNullOrEmpty(addViewModel.StudentRollNo))
            {
                addViewModel.Error = "Please fill all filed";
                return View(addViewModel);
            }
            // studentServies.Add(studentServies.ConvertVmToStudent(addViewModel));
            _studentRepository.Add(studentServies.ConvertVmToStudent(addViewModel));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Rollno)
        {
            _rollno = Rollno;
            if (Convert.ToInt32(Session["login"]) == 1)
            {
                EditViewModel editViewModel = new EditViewModel();
                Student student;
                student = _studentRepository.GetStudent(Rollno);
                if (student != null)
                {
                    editViewModel.EditName = student.Name;
                    editViewModel.EditRollNo = Convert.ToString(Rollno);
                    editViewModel.EditCgpi = Convert.ToString(student.Cgpi);
                    editViewModel.EditLocation = student.Location;
                    editViewModel.EditDOB = student.DOB;
                }

                return View(editViewModel);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel editViewModel)
        {

            if (string.IsNullOrEmpty(editViewModel.EditCgpi) || string.IsNullOrEmpty(editViewModel.EditDOB) ||
                string.IsNullOrEmpty(editViewModel.EditLocation) || string.IsNullOrEmpty(editViewModel.EditName) ||
                string.IsNullOrEmpty(editViewModel.EditRollNo))
            {
                editViewModel.Error = "Please all Fill are Filed";
                return View(editViewModel);
            }
            _studentRepository.Update(Convert.ToInt32(editViewModel.EditRollNo),studentServies.ConvertVmToStudent1(editViewModel));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int RollNo)
        {
            if (Convert.ToInt32(Session["login"]) == 1)
            {
              _studentRepository.Delete(RollNo);
                return Redirect("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

    }

}