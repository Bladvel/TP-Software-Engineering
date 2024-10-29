using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;

namespace BLL
{
    public class ItemIngrediente
    {
        MP_ItemIngrediente mp = MpItemIngredienteCreator.GetInstance.CreateMapper() as MP_ItemIngrediente;

        public string Concatenar(BE.ItemIngrediente item)
        {
            return item.ID + item.Ingrediente.CodIngrediente + item.SolicitudDeCotizacion.NroSolicitud + item.CantidadRequerida + item.PrecioCotizacion.ToString();
        }

        public List<BE.ItemIngrediente> Listar()
        {
            return mp.GetAll();
        }


    }
}
