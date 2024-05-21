using Examen.BE;
using Examen.DAL;

namespace Examen.BLL
{
	public class Gestor
	{
		private PersonaDao _personaDao = new PersonaDao();
		public Gestor()
		{
			_personaDao = new PersonaDao();
		}
		public int GrabarPersona(Usario persona)
		{
			return _personaDao.InsertarPersona(persona);
		}

		public int GetFoldes()
		{
			IList<Componente> dire01 = new List<Componente>();
			IList<Componente> dire02 = new List<Componente>();
			IList<Componente> dire03 = new List<Componente>();
			IList<Componente> dire04 = new List<Componente>();
			IList<Componente> dire05 = new List<Componente>();
			Componente archivo01 = new Archivo();
			Componente archivo02 = new Archivo();
			Componente archivo03 = new Archivo();
			Componente archivo04 = new Archivo();
			Componente archivo05 = new Archivo();
			Componente archivo06 = new Archivo();
			IList<Componente> so = new List<Componente>();

			dire01.Add(archivo01);
			dire01.Add(archivo02);
			dire01.Add(archivo03);
			dire02.Add(archivo01);
			dire03.Add(archivo04);
			dire04.Add(archivo05);
			dire03.Add((Directorio)dire04);
			dire01.Add((Directorio)dire03);

			so.Add((Directorio)dire01);
			so.Add((Directorio)dire02);
			so.Add((Directorio)dire03);
			so.Add((Directorio)dire04);
			so.Add((Directorio)dire05);
			so.Add(archivo06);

			return 1;

		}
	}
}