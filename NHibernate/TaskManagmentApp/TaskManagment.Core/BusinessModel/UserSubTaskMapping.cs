using FluentNHibernate.Mapping;

namespace TaskManagment.Core.BusinessModel
{
    public class UserSubTaskMapping : ClassMap<UserSubTask>
    {
        public UserSubTaskMapping()
        {
            Id(e => e.Id);
            Map(e => e.SubTaskTitle);
            Map(e => e.SubTaskDescription);
            Map(e => e.SubCreateDate);
            Map(e => e.SubModifyDate);
            References(e => e.UserTask);
        }
    }
}
