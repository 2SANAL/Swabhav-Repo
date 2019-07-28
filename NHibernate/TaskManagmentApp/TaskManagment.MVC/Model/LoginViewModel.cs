using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManagment.MVC.Model
{
    public class LoginViewModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Password { get; set; }
        public string Message { get; set; }
    }
}