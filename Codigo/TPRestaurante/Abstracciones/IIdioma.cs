using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IIdioma
    {
        int Id { get; set; }
        string Nombre { get; set; }
        bool Default { get; set; }
    }
}
