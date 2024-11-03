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
    public class Producto
    {
        private MP_Producto mp = MpProductoCreator.GetInstance.CreateMapper() as MP_Producto;
        Bitacora bllBitacora = new Bitacora();
        public List<BE.Producto> Listar()
        {
            return mp.GetAll();
        }

        public int Insertar(BE.Producto producto)
        {
            int resultado = mp.Insert(producto);

            if(resultado != -1)
            {
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Producto,
                    Operacion = TipoOperacion.Alta,
                    Criticidad = 2
                };

                bllBitacora.Insertar(logEntry);
            }



            return resultado;
        }

        public string Modificar(BE.Producto selectedProduct)
        {
            string result;

            if(mp.Update(selectedProduct) != -1)
            {
                result = "Producto modificado con éxito";

                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Producto,
                    Operacion = TipoOperacion.Modificacion,
                    Criticidad = 3
                };

                bllBitacora.Insertar(logEntry);

            }
            else
            {
                result = "Error al modificar producto";
            }
            return result;


        }

        public string Eliminar(BE.Producto selectedProduct)
        {
            string result;

            if(mp.Delete(selectedProduct) != -1)
            {
                result = "Producto eliminado con éxito";

                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Producto,
                    Operacion = TipoOperacion.Baja,
                    Criticidad = 2
                };

                bllBitacora.Insertar(logEntry);

            }
            else
            {
                result = "Error al eliminar producto";
            }

            return result;


        }

        public string Concatenar(BE.Producto producto)
        {
            return producto.CodProducto + producto.Nombre + producto.Descripcion + producto.PrecioActual + producto.Borrado;
        }



    }
}
