using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }

        int Attempts { get; set; }

        List<IComponent> Permissions { get; }
    }
}
