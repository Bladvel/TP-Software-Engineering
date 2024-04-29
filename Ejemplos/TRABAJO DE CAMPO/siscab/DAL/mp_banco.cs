using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mp_banco
    {
        private Acceso ac = new Acceso();

        public List<BE.Banco> Listar()
        {
            List<BE.Banco> bancos = new List<BE.Banco>();
            ac.Abrir();
            DataTable tabla = ac.Leer("select * from banco");
            ac.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                BE.Banco b = new BE.Banco();
                b.Id = int.Parse(registro["id"].ToString());
                b.Nombre = registro["nombre"].ToString();
                bancos.Add(b);
            }
            return bancos;
        }


    }
}
