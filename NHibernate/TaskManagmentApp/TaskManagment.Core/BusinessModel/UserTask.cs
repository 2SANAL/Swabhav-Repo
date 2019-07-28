using System;
using System.Collections.Generic;

namespace TaskManagment.Core.BusinessModel
{
    public class UserTask
    {
        public virtual Guid Id { get; set; }
        public virtual string TaskTitle { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual DateTime ModifyDate { get; set; }
        public virtual string TaskDescription { get; set; }
        public virtual ICollection<UserSubTask> UserSubTasks { get; set; }
        public virtual User User { get; set; }

        public UserTask()
        {
            UserSubTasks = new List<UserSubTask>();
        }
    }
}
