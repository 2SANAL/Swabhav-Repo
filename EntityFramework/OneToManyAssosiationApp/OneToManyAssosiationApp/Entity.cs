using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssosiationApp
{
   public class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
