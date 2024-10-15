using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;

namespace BLL
{
    public class MetodoDePago
    {
        public string Concatenar(BE.MetodoDePago metodoDePago)
        {
            return metodoDePago.id + metodoDePago.tipo.ToString();
        }

        MP_MetodoDePago mp = MpMetodoDePagoCreator.GetInstance.CreateMapper() as MP_MetodoDePago;

        public List<BE.MetodoDePago> Listar()
        {
            return mp.GetAll();
        }
    }
}
