using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;

namespace BLL
{
    public class PagoInsumo
    {
        MP_PagoInsumo mp = MpPagoInsumoCreator.GetInstance().CreateMapper() as MP_PagoInsumo;

        public List<BE.PagoInsumo> ListarPorFactura(BE.Factura factura)
        {
            return mp.GetByFactura(factura.NroFactura);
        }

        public int Insertar(BE.PagoInsumo pagoInsumo)
        {
            return mp.Insert(pagoInsumo);
        }


    }
}
