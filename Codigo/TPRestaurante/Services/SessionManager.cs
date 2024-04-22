using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SessionManager
    {
        private static Session _session;
        private static Object _lock = new Object();

        public static Session Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_session == null)
                    {
                        _session = new Session();
                    }
                    return _session;
                }
            }
        }
    }
}
