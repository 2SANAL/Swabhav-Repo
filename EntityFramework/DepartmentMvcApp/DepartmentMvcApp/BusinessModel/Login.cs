using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DepartmentMvcApp.BusinessModel
{
    [Table("LOGIN")]
    public class Login : Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}