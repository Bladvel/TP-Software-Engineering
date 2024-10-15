using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;

namespace BLL
{
    public class Comanda
    {
        MP_Comanda mp = MpComandaCreator.GetInstance.CreateMapper() as MP_Comanda;
        

        public List<BE.Comanda> ListarEnCursoPorCocinero(BE.User cocinero)
        {
            List<BE.Comanda> comandas = new List<BE.Comanda>();
            BE.Comanda comandaBuscada  = mp.GetAllOnGoing().FirstOrDefault(c => c.Cocinero.ID.Equals(cocinero.ID));
            comandas.Add(comandaBuscada);

            return comandas;
        }

        public int Insertar(BE.Comanda comanda)
        {
            return mp.Insert(comanda);
        }

        public string Concatenar(BE.Comanda comanda)
        {
            return comanda.ID + comanda.Descripcion + comanda.PedidoAsignado.NroPedido + comanda.Cocinero.ID;
        }

        public List<BE.Comanda> Listar()
        {
            return mp.GetAll();
        }


    }
}
