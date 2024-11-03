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
    public class NotaDeEntrega
    {
        MP_NotaDeEntrega mp = MpNotaDeEntregaCreator.GetInstance().CreateMapper() as MP_NotaDeEntrega;
        OrdenDeCompra bllOrdenDeCompra = new OrdenDeCompra();
        Ingrediente bllIngrediente = new Ingrediente();
        Bitacora bllBitacora = new Bitacora();
        public int Insertar(BE.NotaDeEntrega nota)
        {
            int resultado = -1;
            if (nota != null)
            {
                if (bllOrdenDeCompra.ActualizarEstado(nota.OrdenDeCompra, Interfaces.EstadoOrdenDeCompra.FacturaACargar) == -1)
                {
                    return -1;
                }
                else
                {
                    resultado = mp.Insert(nota);

                    if (resultado != -1)
                    {
                        var logUser = SessionManager.Instance.User;
                        var logEntry = new Services.Bitacora
                        {
                            Usuario = logUser,
                            Fecha = DateTime.Now,
                            Modulo = TipoModulo.RecepcionDeInsumos,
                            Operacion = TipoOperacion.Alta,
                            Criticidad = 2
                        };

                        bllBitacora.Insertar(logEntry);
                    }


                    bllIngrediente.ActualizarStock(nota.OrdenDeCompra.Solicitud.Ingredientes);
                }
                
            }
            return resultado;
        }
    }
}
