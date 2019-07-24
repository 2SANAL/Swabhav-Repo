using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WelcomeMvcApp.Model.Registration
{
    public class RegistrationViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessageResourceType =typeof(WelcomeMvcApp.Views.Registration.Error),ErrorMessageResourceName = "InvlaidName")]
        public string Name { get; set; }
        [Range(18,50,ErrorMessage = "Age must be in 18 -50")]
        public string Age { get; set; }
        [Range(10000, 50000, ErrorMessage = "Please Enter 10K -50K")]
        public string Salary { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        public string Email { get; set; }
        public  string Message { get; set; }
        [PasswordValidation]
       public  string Password { get; set; }
    }
}