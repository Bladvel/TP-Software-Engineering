using Abstracciones;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario : IUser, IEntity
    {
		private string _user;

		public string Username
		{
			get { return _user; }
			set { _user = value; }
		}

		private string _pass;

		public string Password
		{
			get { return _pass; }
			set { _pass = value; }
		}

        public Guid Id { get; set; }
    }
}
