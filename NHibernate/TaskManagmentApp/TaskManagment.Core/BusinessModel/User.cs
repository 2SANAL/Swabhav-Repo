using System;
using System.Collections.Generic;

namespace TaskManagment.Core.BusinessModel
{
    public class User
    {
        
        public virtual Guid Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual double Mobile { get; set; }
        public virtual string Password { get; set; }
        public virtual string Address { get; set; }
        public virtual string Role { get; set; }
        public virtual ICollection<UserTask> UserTasks { get; set; }
        public User()
        {
            UserTasks=new List<UserTask>();
        } 
    }
}
