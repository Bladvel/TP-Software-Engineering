using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePersistente
{
	public class Repository
	{


		public IList<Componente> GetAll(string familia)
		{


			var where = "is NULL";

			if (!String.IsNullOrEmpty(familia))
			{
				where = familia;
			}

			var cs = new SqlConnectionStringBuilder();
			cs.IntegratedSecurity = true;
			cs.DataSource = ".";
			cs.InitialCatalog = "composite1";
			var cnn = new SqlConnection(cs.ConnectionString);
			cnn.Open();
			var cmd = new SqlCommand();
			cmd.Connection = cnn;
			
			var sql = $@"with recursivo as (
						select sp2.id_permiso_padre, sp2.id_permiso_hijo  from permiso_permiso SP2
						where sp2.id_permiso_padre {where} --acá se va variando la familia que busco
						UNION ALL 
						select sp.id_permiso_padre, sp.id_permiso_hijo from permiso_permiso sp 
						inner join recursivo r on r.id_permiso_hijo= sp.id_permiso_padre
						)
						select r.id_permiso_padre,r.id_permiso_hijo,p.id,p.nombre, p.es_patente
						from recursivo r 
						inner join permiso p on r.id_permiso_hijo = p.id 
						
						";

			cmd.CommandText = sql;

			var reader = cmd.ExecuteReader();

			var lista = new List<Componente>();

			while (reader.Read())
			{
				int id_padre = 0;
				if (reader["id_permiso_padre"] != DBNull.Value) {
					id_padre = reader.GetInt32(reader.GetOrdinal("id_permiso_padre"));
				}

				var id = reader.GetInt32(reader.GetOrdinal("id"));
				var nombre = reader.GetString(reader.GetOrdinal("nombre"));
				var patente = reader.GetBoolean(reader.GetOrdinal("es_patente"));


				Componente c;

				if (!patente)
					c = new Familia();
				else
					c = new Patente();

				c.Id = id;
				c.Nombre = nombre;

				var padre = GetComponent(id_padre, lista);

				if (padre == null)
				{
					lista.Add(c);
				}
				else
				{
					padre.AgregarHijo(c);
				}
			
			 

			}
			reader.Close();
			cnn.Close();


			return lista;
		}


		public bool IsInRole(int id)
		{
			var lista = GetAll(string.Empty);

			var c = GetComponent(id, lista);

			return c != null;
		}


		private Componente GetComponent(int id, IList<Componente> lista)
		{

						Componente component = lista!=null ? lista.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;

			if (component == null&& lista!=null)
			{
				foreach (var c in lista)
				{
				  
					var l =  GetComponent(id, c.Hijos);
					if (l!=null && l.Id == id) return l;
					else
					if (l != null)
						return GetComponent(id, l.Hijos);

				}
			}

			

			return component;



		}

		
	}

	

}

