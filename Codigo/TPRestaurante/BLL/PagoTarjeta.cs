using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;

namespace BLL
{
    public class PagoTarjeta
    {
        public string Concatenar(BE.PagoTarjeta pagoTarjeta)
        {
            return pagoTarjeta.id + pagoTarjeta.NumeroTarjeta.ToString() + pagoTarjeta.FechaVencimiento +
                   pagoTarjeta.Cvv +
                   pagoTarjeta.Titular;
        }

        MP_PagoTarjeta mp = MpPagoTarjetaCreator.GetInstance.CreateMapper() as MP_PagoTarjeta;

        public List<BE.PagoTarjeta> Listar()
        {
            return mp.GetAll();
        }
    }
}
