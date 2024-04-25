using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Session
    {
        private IUser _user;
        public IUser User { get => _user; }

        public void Login(IUser user)
        { 
            _user = user; 
        }

        public void Logout()
        {
            _user = null;
        }

        public bool IsLoggedIn()
        {
            return _user != null;
        }

        private Session() { }
    }
}
