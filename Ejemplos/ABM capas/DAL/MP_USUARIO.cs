using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_USUARIO : MAPPER<BE.USUARIO>
    {
        private BE.USUARIO usuario;
        
        public override USUARIO Convertir(DataRow dr)
        {
            usuario = new USUARIO();
            MP_ESTADO mpEstado = new MP_ESTADO();
            usuario.ID = int.Parse(dr["ID"].ToString());
            usuario.Nombre = dr["NOMBRE"].ToString();
            usuario.EstadoCivil = mpEstado.Convertir(dr);


            return usuario;
        }

        public override int Deletear(USUARIO obj)
        {
            throw new NotImplementedException();
        }

        public override List<USUARIO> GetList()
        {
            List<BE.USUARIO> list = new List<USUARIO> ();
            acceso.Abrir();
            DataTable dt = acceso.Leer("USUARIO_LISTAR");

            foreach(DataRow dr in dt.Rows)
            {
                list.Add(Convertir(dr));
            }

            return list;
        }

        public override int Insertar(USUARIO obj)
        {
            List<SqlParameter> sp = new List<SqlParameter>
            {
                acceso.CrearParametro("@nom", obj.Nombre),
                acceso.CrearParametro("@dni", obj.DNI),
                acceso.CrearParametro("@id_cat",obj.EstadoCivil.ID)
            };
            acceso.Abrir();
            int filasAfectadas = acceso.Escribir("USUARIO_ALTA", sp);
            acceso.Cerrar();
            return filasAfectadas;
        
        }

        public override int Updatear(USUARIO obj)
        {
            throw new NotImplementedException();
        }
    }
}
