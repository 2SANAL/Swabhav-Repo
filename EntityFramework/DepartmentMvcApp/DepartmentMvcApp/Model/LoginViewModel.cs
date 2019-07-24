using System.ComponentModel.DataAnnotations;

namespace DepartmentMvcApp.Model
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}