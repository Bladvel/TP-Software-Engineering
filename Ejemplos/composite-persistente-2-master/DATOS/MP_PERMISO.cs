using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
namespace DATOS
{

	public class MP_PERMISO
	{

		Acceso acceso;
		bool accesopropio;
		public MP_PERMISO()
		{

			accesopropio=true;
			acceso= new Acceso();
		}

		internal MP_PERMISO(Acceso ac)
		{

			acceso = ac;
			accesopropio=false;
		}

		private void Abrir()
		{

			if (accesopropio)
			{

				acceso.Abrir();
			}

		}

		private void IniciarTx()
		{

			if (accesopropio)
			{

				acceso.ComenzarTransaccion();
			}

		}

		private void FinalizarTx(int i)
		{

			if (accesopropio)
			{

				if(i >=0){ acceso.ConfirmarTransaccion();}else{acceso.CancelarTransaccion();}
			}

		}

		private void Cerrar()
		{

			if (accesopropio)
			{

				acceso.Cerrar();
			}

		}


		public List<CLASES.PERMISO> Listar()
		{

			List<CLASES.PERMISO> lista = new List<CLASES.PERMISO>();
			List<SqlParameter> pars = new List<SqlParameter>();
			Abrir();
			DataTable tabla = acceso.Leer("PERMISO_Listar", pars);
			foreach (DataRow registro in tabla.Rows)
			{

				CLASES.PERMISO obj;
				if (registro["ID_PERMISO"].ToString() == "P")
				{
					obj = new CLASES.PERMISO();
				}
				else
				{
					obj = new CLASES.GRUPO();
				}
				obj.Id = int.Parse(registro["ID_PERMISO"].ToString());
				obj.Descripcion = registro["PERMISO"].ToString();
				lista.Add(obj);
			}
			tabla = null;
			if (lista.Count > 0)
			{
				tabla = acceso.Leer("GRUPO_LISTAR", pars);
				foreach (DataRow registro in tabla.Rows)
				{
					CLASES.GRUPO grupo = (from CLASES.GRUPO g in lista
										  where g.Id == int.Parse(registro["ID_GRUPO"].ToString())
										  select g).FirstOrDefault();
					CLASES.PERMISO permiso = (from CLASES.PERMISO p in lista
											  where p.Id == int.Parse(registro["ID_PERMISO"].ToString())
											  select p).FirstOrDefault();
					grupo.Permisos.Add(permiso);
				}              
			}
			Cerrar();
			return lista;
		}
		public void Listar(CLASES.USUARIO usuario)
		{
			List<CLASES.PERMISO> lista = Listar();
			List<SqlParameter> pars = new List<SqlParameter>();
			pars.Add(acceso.CrearParametro("@id", usuario.Id));
			Abrir();
			DataTable tabla = acceso.Leer("USUARIO_PERMISO_LISTAR", pars);
			foreach (DataRow registro in tabla.Rows)
			{
				usuario.Permisos.Add((from CLASES.PERMISO p in lista
									  where p.Id == int.Parse(registro["ID_PERMISO"].ToString())
									  select p).FirstOrDefault());

			}
			Cerrar();
		}
	   
		 
	 }

}

