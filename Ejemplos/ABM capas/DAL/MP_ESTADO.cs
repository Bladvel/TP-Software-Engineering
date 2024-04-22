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
    public class MP_ESTADO : MAPPER<BE.ESTADO>
    {
        BE.ESTADO estado;
        //ACCESO acceso = new ACCESO();
        public override ESTADO Convertir(DataRow dr)
        {
            estado = new BE.ESTADO();
            estado.ID = int.Parse(dr["ID"].ToString());
            estado.Estado = dr["ESTADO"].ToString();

            return estado;
        }

        public override int Deletear(ESTADO obj)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.CrearParametro("@id", obj.ID));
            acceso.Abrir();
            int filasAfectadas = acceso.Escribir("ESTADO_ELIMINAR", parameters);
            acceso.Cerrar();
            return filasAfectadas;
        }

        public override List<ESTADO> GetList()
        {
            List<BE.ESTADO> estados = new List<BE.ESTADO>();
            acceso.Abrir();
            DataTable dt = acceso.Leer("ESTADO_LISTAR");
            acceso.Cerrar();

            foreach (DataRow dr in dt.Rows)
            {
                estados.Add(Convertir(dr));
            }

            return estados;
        }

        public override int Insertar(ESTADO obj)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.CrearParametro("@nom",obj.Estado));
            acceso.Abrir();
            int filasAfectadas = acceso.Escribir("ESTADO_ALTA", parameters);
            acceso.Cerrar();
            return filasAfectadas;
        }

        public override int Updatear(ESTADO obj)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.CrearParametro("@nom", obj.Estado));
            parameters.Add(acceso.CrearParametro("@id", obj.ID));
            acceso.Abrir();
            int filasAfectadas = acceso.Escribir("ESTADO_MODIFICAR", parameters);
            acceso.Cerrar();
            return filasAfectadas;
        }
    }
}
