using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SessionManager
    {
        private SessionManager() { }
        private static SessionManager _instance;
        private static Object _lock = new Object();

        public static SessionManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SessionManager();
                    }
                    return _instance;
                }
            }
        }


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


        public bool IsInRole(IComponent c, PermissionType permissionType)
        {
            if (c.PermissionType.Equals(permissionType))
                return true;


            foreach (var child in c.Children)
            {
                if (IsInRole(child, permissionType))
                    return true;
            }

            return false;
        }

        public bool IsInRole(PermissionType permissionType)
        {
            foreach (var userPermission in User.Permissions)
            {
                if (IsInRole(userPermission, permissionType))
                    return true;
            }

            return false;
        }
    }
}
