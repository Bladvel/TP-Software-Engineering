using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;
using Services;

namespace BLL
{
    public class DVV
    {
        MP_Dvv mp = MpDvvCreator.GetInstance.CreateMapper() as MP_Dvv;

        public List<Services.DVV> Listar()
        {
            return mp.GetAll();
        }

        public int Insertar(Services.DVV dvv)
        {
            return mp.Insert(dvv);
        }

        public int Actualizar(Services.DVV dvv)
        {
            return mp.Update(dvv);
        }

        public void BorrarRegistros()
        {
            mp.DeleteAll();
        }

        public string ObtenerDV(string cadena)
        {
            return CryptoManager.Hash(cadena);
        }

        //TODO: Implementar DVV de bll



    }
}
