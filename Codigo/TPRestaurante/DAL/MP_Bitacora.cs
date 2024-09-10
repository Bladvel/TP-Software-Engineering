﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Services;

namespace DAL
{
    public class MP_Bitacora: Mapper<Bitacora>
    {
        public override Bitacora GetById(object id)
        {
            throw new NotImplementedException();
        }
        MP_User mpUser = new MP_User();
        public override Bitacora Transform(DataRow dr)
        {
            Bitacora bitacora = new Bitacora();
            bitacora.ID = int.Parse(dr["ID"].ToString());
            bitacora.Fecha = DateTime.Parse(dr["FECHA"].ToString());

            Guid userId = Guid.Parse(dr["ID_USUARIO"].ToString());
            bitacora.Usuario = mpUser.GetById(userId);
            bitacora.Modulo = (TipoModulo)Enum.Parse(typeof(TipoModulo), dr["MODULO"].ToString());
            bitacora.Operacion = (TipoOperacion)Enum.Parse(typeof(TipoOperacion), dr["OPERACION"].ToString());
            bitacora.Criticidad = int.Parse(dr["CRITICIDAD"].ToString());

            return bitacora;


        }

        public override List<Bitacora> GetAll()
        {
            List<Bitacora> bitacoras = new List<Bitacora>();

            access.Open();
            DataTable dt = access.Read("LISTAR_BITACORA");
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                bitacoras.Add(Transform(dr));
            }

            return bitacoras;

        }

        public override int Insert(Bitacora entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@ID_USUARIO", entity.Usuario.ID),
                access.CreateParameter("@MODULO", entity.Modulo.ToString()),
                access.CreateParameter("@OPERACION", entity.Operacion.ToString()),
                access.CreateParameter("@CRITICIDAD", entity.Criticidad),
                access.CreateParameter("@FECHA", entity.Fecha)
            };

            access.Open();
            int filasAfectadas = access.Write("INSERTAR_BITACORA", parameters);
            access.Close();

            return filasAfectadas;

        }

        public override int Update(Bitacora entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Bitacora entity)
        {
            throw new NotImplementedException();
        }

        public List<Bitacora> Filter(DateTime fi, DateTime ff)
        {
            List<Bitacora> bitacora = new List<Bitacora>();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@FechaInicio", fi),
                access.CreateParameter("@FechaFin", ff)
            };

            access.Open();
            DataTable dt = access.Read("LISTAR_BITACORA_POR_FECHA", parameters);
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                bitacora.Add(Transform(dr));
            }

            return bitacora;
        }


    }
}
