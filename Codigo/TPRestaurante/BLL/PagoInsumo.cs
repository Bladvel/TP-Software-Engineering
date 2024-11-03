using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;
using Interfaces;
using Services;

namespace BLL
{
    public class PagoInsumo
    {
        MP_PagoInsumo mp = MpPagoInsumoCreator.GetInstance().CreateMapper() as MP_PagoInsumo;
        Bitacora bllBitacora = new Bitacora();
        public List<BE.PagoInsumo> ListarPorFactura(BE.Factura factura)
        {
            return mp.GetByFactura(factura.NroFactura);
        }

        public int Insertar(BE.PagoInsumo pagoInsumo)
        {
            int resultado = mp.Insert(pagoInsumo);

            if(resultado != -1)
            {
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.PagoInsumo,
                    Operacion = TipoOperacion.Alta,
                    Criticidad = 2
                };

                bllBitacora.Insertar(logEntry);
            }




            return resultado;
        }


    }
}
