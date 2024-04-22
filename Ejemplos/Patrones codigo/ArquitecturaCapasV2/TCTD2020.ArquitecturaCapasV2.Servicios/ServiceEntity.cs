using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV2.Interfaces;

namespace TCTD2020.ArquitecturaCapasV2.Servicios
{
    public class ServiceEntity : IEntity
    {
        public Guid Id { get; set; }
    }
}
