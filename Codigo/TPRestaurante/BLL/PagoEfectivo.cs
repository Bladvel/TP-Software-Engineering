using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;

namespace BLL
{
    public class PagoEfectivo
    {
        public string Concatenar(BE.PagoEfectivo pagoEfectivo)
        {
            return pagoEfectivo.id + pagoEfectivo.Monto.ToString();
        }

        MP_PagoEfectivo mp = MpPagoEfectivoCreator.GetInstance.CreateMapper() as MP_PagoEfectivo;

        public List<BE.PagoEfectivo> Listar()
        {
            return mp.GetAll();
        }
    }
}
