using FluentNHibernate.Mapping;

namespace TaskManagment.Core.BusinessModel
{
    public class UserTaskMapping : ClassMap<UserTask>
    {
        public UserTaskMapping()
        {
            Id(e => e.Id);
            Map(e => e.TaskTitle);
            Map(e => e.TaskDescription);
            Map(e => e.CreateDate);
            Map(e => e.ModifyDate);
            HasMany(e => e.UserSubTasks).Cascade.All();
            References(e => e.User);
        }
    }
}
