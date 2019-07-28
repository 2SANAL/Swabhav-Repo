using FluentNHibernate.Mapping;

namespace TaskManagment.Core.BusinessModel
{
    public class UserMapping : ClassMap<User>
    {
        public UserMapping()
        {
            Id(e => e.Id);
            Map(e => e.UserName);
            Map(e => e.Password);
            Map(e => e.Email);
            Map(e => e.Address);
            Map(e => e.Mobile);
            Map(e => e.Role);
            HasMany(e => e.UserTasks).Cascade.All();
        }
    }
}
