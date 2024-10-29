using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class MP_ItemIngrediente: Mapper<ItemIngrediente>
    {
        public MP_ItemIngrediente(Access access, MP_Ingrediente mpIngrediente) : base(access)
        {
            this.mpIngrediente = mpIngrediente;
        }

        public override ItemIngrediente GetById(object id)
        {
            throw new NotImplementedException();
        }


        private MP_Ingrediente mpIngrediente;

        public override ItemIngrediente Transform(DataRow dr)
        {
            ItemIngrediente item = new ItemIngrediente();
            item.ID = int.Parse(dr["ID"].ToString());
            item.SolicitudDeCotizacion = new SolicitudDeCotizacion();
            item.SolicitudDeCotizacion.NroSolicitud = int.Parse(dr["NRO_SOLICITUD"].ToString());
            item.Ingrediente = mpIngrediente.GetById(dr["COD_INGREDIENTE"].ToString());
            item.CantidadRequerida = int.Parse(dr["CANTIDAD"].ToString());
            item.PrecioCotizacion = float.Parse(dr["PRECIO_COTIZACION"].ToString());
            return item;

        }

        public override List<ItemIngrediente> GetAll()
        {
            List<ItemIngrediente> items = new List<ItemIngrediente>();

            access.Open();
            DataTable dt = access.Read("LISTAR_ITEM_INGREDIENTE");
            access.Close();
            foreach (DataRow dr in dt.Rows) {
                items.Add(Transform(dr));
            }
            return items;
        }

        public List<ItemIngrediente> GetItemsBySolicitud(int solicitudId)
        {
            List<ItemIngrediente> items = new List<ItemIngrediente>();
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nro", solicitudId),
            };

            access.Open();
            DataTable dt = access.Read("LISTAR_ITEM_INGREDIENTE_POR_SOLICITUD", parameters);
            access.Close();

            foreach (DataRow dr in dt.Rows)
            {
                items.Add(Transform(dr));
            }

            return items;
        }


        public override int Insert(ItemIngrediente entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@codIngrediente", entity.Ingrediente.CodIngrediente),
                access.CreateParameter("@nroSolicitud", entity.SolicitudDeCotizacion.NroSolicitud),
                access.CreateParameter("@cantidad", entity.CantidadRequerida),
                access.CreateParameter("@precioCotizacion", entity.PrecioCotizacion)
            };

            access.Open();
            int result = access.Write("INSERTAR_ITEM_INGREDIENTE", parameters);
            access.Close();
            return result;


        }
        

        public override int Update(ItemIngrediente entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(ItemIngrediente entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteBySolicitud(int solicitudId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@NroSolicitud", solicitudId)
            };

            access.Open();
            int result = access.Write("ELIMINAR_ITEM_INGREDIENTE_POR_SOLICITUD", parameters);
            access.Close();
            return result;
        }
    }
}
