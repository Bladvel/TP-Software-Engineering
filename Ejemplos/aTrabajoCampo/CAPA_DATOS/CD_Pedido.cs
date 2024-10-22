using CAPA_DATOS.DAOs;
using CAPA_ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class CD_Pedido
    {
        private static CD_Pedido instance;

        public static CD_Pedido GetInstance()
        {
            if (instance == null)
            {
                instance = new CD_Pedido();
            }

            return instance;
        }

        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;
            try
            {
                idCorrelativo = DAOs_Pedido.GetInstance().ObtenerCorrelativo();
            }
            catch (Exception)
            {
                idCorrelativo = 0;
            }
            return idCorrelativo;
        }

        public bool SumarStock(int idArticulo, int cantidad)
        {
            bool respuesta = false;

            try
            {
                respuesta = DAOs_Pedido.GetInstance().SumarStock(idArticulo, cantidad);
            }
            catch (Exception)
            {
                respuesta=false;
                throw;
            }
            
            return respuesta;
        }

        public bool RestarStock(int idArticulo, int cantidad)
        {
            bool respuesta = false;

            try
            {
                respuesta = DAOs_Pedido.GetInstance().RestarStock(idArticulo, cantidad);
            }
            catch (Exception)
            {
                respuesta = false;
                throw;
            }

            return respuesta;
        }

        public bool Registrar(Pedido obj, DataTable detallePedido, out string msj)
        {
            bool respuesta = false;
            msj = string.Empty;

            try
            {
                respuesta = DAOs_Pedido.GetInstance().Registrar(obj,detallePedido,out msj);
            }
            catch (Exception ex)
            {
                respuesta = false;
                msj = ex.Message;
            }

            return respuesta;
        }

        public List<Pedido> GetAll()
        {
            try
            {
                return DAOs_Pedido.GetInstance().GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
