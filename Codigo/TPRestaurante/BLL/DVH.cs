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
    public static class DVH
    {
        static MP_Dvh mpDvh = MpDvhCreator.GetInstance.CreateMapper() as MP_Dvh;


        //Aqui van todas las clases de negocio que se les pondra el DVH

        static Cliente bllCliente = new Cliente();
        static Comanda bllComanda = new Comanda();
        static Ingrediente bllIngrediente = new Ingrediente();
        static ItemProducto bllItemProducto = new ItemProducto();
        static MetodoDePago bllMetodoDePago = new MetodoDePago();
        static Pago bllPago = new Pago();
        static PagoEfectivo bllPagoEfectivo = new PagoEfectivo();
        static PagoTarjeta bllPagoTarjeta = new PagoTarjeta();
        static Pedido bllPedido = new Pedido();
        static Producto bllProducto = new Producto();
        
        static Factura bllFactura = new Factura();
        static ItemIngrediente bllItemIngrediente = new ItemIngrediente();
        static NotaDeEntrega bllNotaDeEntrega = new NotaDeEntrega();
        static OrdenDeCompra bllOrdenDeCompra = new OrdenDeCompra();
        static PagoInsumo bllPagoInsumo = new PagoInsumo();
        static Proveedor bllProveedor = new Proveedor();
        static SolicitudDeCotizacion bllSolicitudDeCotizacion = new SolicitudDeCotizacion();

        public static List<RegistroInvalido> ValidarDigitoVerificador()
        {
            List<RegistroInvalido> registrosInvalidos = new List<RegistroInvalido>();

            // Listas de objetos
            List<BE.Cliente> clientes = bllCliente.Listar();
            List<BE.Comanda> comandas = bllComanda.Listar();
            List<BE.Ingrediente> ingredientes = bllIngrediente.Listar();
            List<BE.ItemProducto> itemProductos = bllItemProducto.Listar();
            List<BE.MetodoDePago> metodosDePago = bllMetodoDePago.Listar();
            List<BE.Pago> pagos = bllPago.Listar();
            List<BE.PagoEfectivo> pagosEfectivo = bllPagoEfectivo.Listar();
            List<BE.PagoTarjeta> pagosTarjeta = bllPagoTarjeta.Listar();
            List<BE.Pedido> pedidos = bllPedido.Listar();
            List<BE.Producto> productos = bllProducto.Listar();


            List<BE.Factura> facturas = bllFactura.Listar();
            List<BE.ItemIngrediente> itemIngredientes = bllItemIngrediente.Listar();
            List<BE.NotaDeEntrega> notasDeEntrega = bllNotaDeEntrega.Listar();
            List<BE.OrdenDeCompra> ordenesDeCompra = bllOrdenDeCompra.Listar();
            List<BE.PagoInsumo> pagosInsumo = bllPagoInsumo.Listar();
            List<BE.Proveedor> proveedores = bllProveedor.Listar();
            List<BE.SolicitudDeCotizacion> solicitudesDeCotizacion = bllSolicitudDeCotizacion.Listar();

            // Listado de DVH (Digito Verificador Horizontal)
            List<Services.DVH> dVHs = Listar();

            foreach (var dvh in dVHs)
            {
                bool registroValido = true;
                string estado = "";

                // Validación para cada tabla
                switch (dvh.Tabla)
                {
                    case "CLIENTE":
                        ValidarRegistro(clientes, bllCliente.Concatenar, cliente => cliente.ID, dvh, ref registroValido, ref estado);
                        break;
                    case "COMANDA":
                        ValidarRegistro(comandas, bllComanda.Concatenar, comanda => comanda.ID, dvh, ref registroValido, ref estado);
                        break;
                    case "FACTURA":
                        ValidarRegistro(facturas, bllFactura.Concatenar, factura => factura.NroFactura, dvh, ref registroValido, ref estado);
                        break;
                    case "INGREDIENTE":
                        ValidarRegistro(ingredientes, bllIngrediente.Concatenar, ingrediente => ingrediente.CodIngrediente, dvh, ref registroValido, ref estado);
                        break;
                    case "ITEM_INGREDIENTE":
                        ValidarRegistro(itemIngredientes, bllItemIngrediente.Concatenar, item => item.ID, dvh,
                            ref registroValido, ref estado);
                        break;

                    case "ITEM_PRODUCTO":
                        ValidarRegistro(itemProductos, bllItemProducto.Concatenar, itemProducto => itemProducto.Id, dvh, ref registroValido, ref estado);
                        break;
                    case "METODO_DE_PAGO":
                        ValidarRegistro(metodosDePago, bllMetodoDePago.Concatenar, metodo => metodo.id, dvh, ref registroValido, ref estado);
                        break;
                    case "NOTA_DE_ENTREGA":
                        ValidarRegistro(notasDeEntrega, bllNotaDeEntrega.Concatenar, nota => nota.NroNota, dvh,
                            ref registroValido, ref estado);
                        break;
                    case "ORDEN_DE_COMPRA":
                        ValidarRegistro(ordenesDeCompra, bllOrdenDeCompra.Concatenar, ordenDeCompra => ordenDeCompra.NroOrden, dvh, ref registroValido, ref estado);
                        break;
                    case "PAGO":
                        ValidarRegistro(pagos, bllPago.Concatenar, pago => pago.Id, dvh, ref registroValido, ref estado);
                        break;
                    case "PAGO_TARJETA":
                        ValidarRegistro(pagosTarjeta, bllPagoTarjeta.Concatenar, pagoTarjeta => pagoTarjeta.id, dvh, ref registroValido, ref estado);
                        break;
                    case "PAGO_INSUMO":
                        ValidarRegistro(pagosInsumo, bllPagoInsumo.Concatenar, pago => pago.NroPago, dvh,
                            ref registroValido, ref estado);
                        break;
                    case "PAGO_EFECTIVO":
                        ValidarRegistro(pagosEfectivo, bllPagoEfectivo.Concatenar, pagoEfectivo => pagoEfectivo.id, dvh, ref registroValido, ref estado);
                        break;
                    case "PEDIDO":
                        ValidarRegistro(pedidos, bllPedido.Concatenar, pedido => pedido.NroPedido, dvh, ref registroValido, ref estado);
                        break;
                    case "PRODUCTO":
                        ValidarRegistro(productos, bllProducto.Concatenar, producto => producto.CodProducto, dvh, ref registroValido, ref estado);
                        break;
                    case "PROVEEDOR":
                        ValidarRegistro(proveedores, bllProveedor.Concatenar, proveedor => proveedor.Cuit, dvh, ref registroValido, ref estado);
                        break;
                    case "SOLICITUD_DE_COMPRA": //Solicitud de cotizacion en el sistema
                        ValidarRegistro(solicitudesDeCotizacion, bllSolicitudDeCotizacion.Concatenar,
                            solicitud => solicitud.NroSolicitud, dvh, ref registroValido, ref estado);
                        break;

                    default:
                        registroValido = false;
                        estado = "Tabla desconocida";
                        break;
                }

                if (!registroValido)
                {
                    registrosInvalidos.Add(new RegistroInvalido { Dvh= dvh, Estado = estado });
                }
            }

            return registrosInvalidos;
        }


        public static bool ValidarRegistro<T>(List<T> lista, Func<T, string> concatenar, Func<T, object> obtenerId, Services.DVH dvh, ref bool registroValido, ref string estado)
        {
            var registro = lista.FirstOrDefault(r => obtenerId(r).Equals(dvh.Registro));
            if (registro != null)
            {
                var cadena = concatenar(registro);
                var hash = ObtenerDV(cadena);
                if (hash != dvh.DV)
                {
                    registroValido = false;
                    estado = "Modificado";
                }
            }
            else
            {
                registroValido = false;
                estado = "Eliminado";
            }
            return registroValido;
        }




        public static List<Services.DVH> Listar()
        {
            return mpDvh.GetAll();
        }

        public static int Insertar(Services.DVH dvh)
        {
            return mpDvh.Insert(dvh);
        }

        public static int Actualizar(Services.DVH dvh)
        {
            return mpDvh.Update(dvh);
        }

        public static int Eliminar(Services.DVH dvh)
        {
            return mpDvh.Delete(dvh);
        }



        public static string ObtenerDV(string cadena)
        {
            return CryptoManager.Hash(cadena);
        }

        public static void Recalcular<T>(List<Services.DVH> dvhs, List<T> items, Func<T, string> concatenar, Func<T, int> obtenerId, string tabla)
        {

            //modificacion para considerar el caso en que elimine un elemento de una tabla
            HashSet<int> idsActuales = items.Select(obtenerId).ToHashSet();

            for (int i = 0; i < items.Count; i++)
            {
                string cadena = concatenar(items[i]);
                Services.DVH dvh = new Services.DVH();
                dvh.Tabla = tabla;
                dvh.Registro = obtenerId(items[i]);
                dvh.DV = ObtenerDV(cadena);

                var existeDvh = dvhs.FirstOrDefault(d => d.Tabla == dvh.Tabla && d.Registro == dvh.Registro);
                if (existeDvh != null)
                {
                    Actualizar(dvh);
                }
                else
                {
                    Insertar(dvh);
                }
            }

            // Eliminar DVH que ya no corresponden a ningún registro actual
            foreach (var dvh in dvhs)
            {
                if (dvh.Tabla == tabla && !idsActuales.Contains(dvh.Registro))
                {
                    Eliminar(dvh); 
                }
            }



        }




        [Obsolete("Este metodo no se usa mas, se reemplazo por Recalcular")]
        public static bool ValidarCantidadRegistros<T>(List<T> entidades, List<Services.DVH> dVHs, string tabla)
        {
            bool ok = true;


            List<Services.DVH> dVHsFiltrados = dVHs.Where(dvh => dvh.Tabla == tabla).ToList();


            if (entidades.Count != dVHsFiltrados.Count)
            {
                ok = false;
            }

            return ok;
        }





    }
}
