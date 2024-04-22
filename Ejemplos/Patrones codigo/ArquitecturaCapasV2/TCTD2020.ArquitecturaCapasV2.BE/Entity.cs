using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV2.Interfaces;

namespace TCTD2020.ArquitecturaCapasV2.BE
{
    public abstract class Entity : IEntity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get;  }
    }
}
