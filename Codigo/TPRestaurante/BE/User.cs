using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	public class User : IUser
	{
		private string user;

		public string Username
		{
			get { return user; }
			set { user = value; }
		}

		private string pass;

		public string Password
		{
			get { return pass; }
			set { pass = value; }
		}

		public Guid ID { get; set; }

		private string dni;

		public string DNI
		{
			get { return dni; }
			set { dni = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		public string NombreCompleto
		{
			get
			{
				return $"{Nombre} {Apellido}";
			}
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private bool activo;

		public bool Activo //borrado logico
		{
			get { return activo; }
			set { activo = value; }
		}

		private bool bloqueo;

		public bool Bloqueo
		{
			get { return bloqueo; }
			set { bloqueo = value; }
		}

		private int _attempts = 0;
		public int Attempts 
		{ 
			get => _attempts; 
			set => _attempts=value; 
		}

		public IIdioma Idioma { get; set; }


		private AvailabilityType availability;

		public AvailabilityType Availability
		{
			get => availability;
			set => availability = value;
		}



		private List<IComponent> permissions = new List<IComponent>();

		public List<IComponent> Permissions => permissions;

		public override string ToString()
		{
			return Nombre;
		}
	}
}
