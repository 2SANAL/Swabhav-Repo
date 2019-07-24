using System;

namespace DepartmentMvcApp.BusinessModel
{
    public class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            this.Id= Guid.NewGuid();
        }
    }
}