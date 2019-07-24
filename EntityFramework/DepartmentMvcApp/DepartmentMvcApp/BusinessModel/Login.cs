using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentMvcApp.BusinessModel
{
    [Table("LOGIN")]
    public class Login : Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}