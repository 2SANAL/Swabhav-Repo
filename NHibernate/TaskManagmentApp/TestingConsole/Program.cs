using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Core.BusinessModel;
using TaskManagment.Core.Services;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User();
            user.Address = "Mumbai";
            user.Email = "akash@a.com";
            user.Mobile = 8446997740;
            user.Password = "123";
            user.UserName = "Akash";
            user.Role = "Admin";
            UserService service = new UserService();
            bool r = service.AddUser(user);
            if (r == true)
            {
                Console.WriteLine(r);
            }

        }
    }
}
