using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
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
        DVH bllDvh = new DVH();

        public int Insertar(BE.NotaDeEntrega nota)
        {
            int resultado = -1;
            if (nota != null)
            {
                if (bllOrdenDeCompra.ActualizarEstado(nota.OrdenDeCompra,
                        Interfaces.EstadoOrdenDeCompra.FacturaACargar) == -1)
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
                        bllDvh.Recalcular(bllDvh.Listar(), Listar(), Concatenar, c => c.NroNota, "NOTA_DE_ENTREGA");
                    }


                    bllIngrediente.ActualizarStock(nota.OrdenDeCompra.Solicitud.Ingredientes);
                }

            }

            return resultado;
        }

        public string Concatenar(BE.NotaDeEntrega nota)
        {
            return nota.NroNota.ToString() + nota.Fecha + nota.OrdenDeCompra.NroOrden + nota.EstadoNota +
                   nota.Observaciones;

        }

        public List<BE.NotaDeEntrega> Listar()
        {
            return mp.GetAll();
        }
    }
}
