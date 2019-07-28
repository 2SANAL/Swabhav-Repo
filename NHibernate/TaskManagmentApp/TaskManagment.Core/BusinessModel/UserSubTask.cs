using System;

namespace TaskManagment.Core.BusinessModel
{
    public class UserSubTask
    {
        public virtual Guid Id { get; set; }
        public virtual string SubTaskTitle { get; set; }
        public virtual DateTime SubCreateDate { get; set; }
        public virtual DateTime SubModifyDate { get; set; }
        public virtual string SubTaskDescription { get; set; }
        public virtual UserTask UserTask { get; set; }
    }
}
