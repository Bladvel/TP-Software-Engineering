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
    public class Cliente
    {
        MP_Cliente mp = MpClienteCreator.GetInstance.CreateMapper() as MP_Cliente;
        BLL.Bitacora bllBitacora = new BLL.Bitacora();
        public int Insertar(BE.Cliente cliente)
        {
            int resultado = mp.Insert(cliente);

            if (resultado != -1)
            {
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Cliente,
                    Operacion = TipoOperacion.Alta,
                    Criticidad = 2
                };

                
                bllBitacora.Insertar(logEntry);
                BLL.DVH.Recalcular(BLL.DVH.Listar(), Listar(), Concatenar, c => c.ID, "CLIENTE");
                DVV.Recalcular(Listar().Cast<object>().ToList(), typeof(BE.Cliente));
            }



            return resultado;
        }

        public List<BE.Cliente> Listar()
        {
            return mp.GetAll();
        }

        public string Modificar(BE.Cliente cliente)
        {
            string result;
            if (mp.Update(cliente) != -1)
            {
                result = "Cliente modificado con éxito";
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Cliente,
                    Operacion = TipoOperacion.Modificacion,
                    Criticidad = 3
                };


                bllBitacora.Insertar(logEntry);
                BLL.DVH.Recalcular(BLL.DVH.Listar(), Listar(), Concatenar, c => c.ID, "CLIENTE");
                DVV.Recalcular(Listar().Cast<object>().ToList(), typeof(BE.Cliente));
            }
            else
            {
                result = "Error al modificar cliente";
            }

            return result;
        }

        public string Eliminar(BE.Cliente cliente)
        {
            string result;
            if (mp.Delete(cliente) != -1)
            {
                result = "Cliente eliminado con éxito";
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Cliente,
                    Operacion = TipoOperacion.Baja,
                    Criticidad = 2
                };


                bllBitacora.Insertar(logEntry);
                BLL.DVH.Recalcular(BLL.DVH.Listar(), Listar(), Concatenar, c => c.ID, "CLIENTE");
                DVV.Recalcular(Listar().Cast<object>().ToList(), typeof(BE.Cliente));
            }
            else
            {
                result = "Error al eliminar cliente";
            }

            return result;
        }


        public string Concatenar(BE.Cliente cliente)
        {
            return cliente.ID + cliente.Nombre + cliente.Apellido + cliente.DNI + cliente.Telefono + cliente.Activo;
        }

    }
}
