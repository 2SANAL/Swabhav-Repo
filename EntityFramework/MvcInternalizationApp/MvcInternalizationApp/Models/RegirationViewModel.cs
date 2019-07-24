using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MvcInternalizationApp.Models
{
    public class RegirationViewModel
    {
        [Display(Name = "Username", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = "UsernameRequried", ErrorMessageResourceType = typeof(Resource))]
        public string Username { get; set; }
        [Display(Name = "Name", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = "NameRequried", ErrorMessageResourceType = typeof(Resource))]
        public string Name { get; set; }
        [Display(Name = "Password", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = "PasswordRequried", ErrorMessageResourceType = typeof(Resource))]
        public string Password { get; set; }
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = "ConfirmPasswordRequried", ErrorMessageResourceType = typeof(Resource))]
        [Compare("Password", ErrorMessageResourceName = "ConfirmPasswordCompare", ErrorMessageResourceType = typeof(Resource))]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Addres", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = "AddresRequired", ErrorMessageResourceType = typeof(Resource))]
        public string Address { get; set; }
        
    }
}