using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;
using Interfaces;
using Services;

namespace BLL
{
    public static class DVV
    {
        static MP_Dvv mp = MpDvvCreator.GetInstance.CreateMapper() as MP_Dvv;

        public static List<Services.DVV> Listar()
        {
            return mp.GetAll();
        }

        public static int Insertar(Services.DVV dvv)
        {
            return mp.Insert(dvv);
        }

        public static int Actualizar(Services.DVV dvv)
        {
            return mp.Update(dvv);
        }

        public static void BorrarRegistros()
        {
            mp.DeleteAll();
        }

        public static string ObtenerDV(string cadena)
        {
            return CryptoManager.Hash(cadena);
        }

        //TODO: Implementar DVV de bll

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

        //Da una lista con el nombre de las columnas mapeadas de cada entidad
        private static List<string> GetMappedColumns(Type entityType)
        {
            return entityType.GetProperties()
                .Where(prop => prop.GetCustomAttribute<ColumnMappingAttribute>() != null)
                .Select(prop => prop.GetCustomAttribute<ColumnMappingAttribute>().ColumnName)
                .ToList();
        }

        //Da el nombre de la tabla mapeada de una entidad
        private static string GetTableName(Type entityType)
        {
            return entityType.GetCustomAttribute<TableMappingAttribute>().TableName;
        }


        //Da el valor de un campo de una columna mapeada de una entidad
        private static string ObtenerValorColumna<T>(T entity, string columnName)
        {
            var property = entity.GetType().GetProperties()
                .FirstOrDefault(prop => prop.GetCustomAttribute<ColumnMappingAttribute>()?.ColumnName == columnName);

            return property?.GetValue(entity)?.ToString() ?? "";
        }

        //Da una string concatenada con todos los valores de una columna mapeada de una lista de entidades
        private static string ConcatenarColumna<T>(List<T> entities, string columnName)
        {
            return string.Join("", entities.Select(entity => ObtenerValorColumna(entity, columnName)));
        }

        public static void Recalcular()
        {
            List<Services.DVV> dVVs = Listar();

            var entitiesAndColumns = new List<(List<object> entities, Type entityType)>
            {
                (bllCliente.Listar().Cast<object>().ToList(), typeof(BE.Cliente)),
                (bllComanda.Listar().Cast<object>().ToList(), typeof(BE.Comanda)),
                (bllIngrediente.Listar().Cast<object>().ToList(), typeof(BE.Ingrediente)),
                (bllItemProducto.Listar().Cast<object>().ToList(), typeof(BE.ItemProducto)),
                (bllMetodoDePago.Listar().Cast<object>().ToList(), typeof(BE.MetodoDePago)),
                (bllPago.Listar().Cast<object>().ToList(), typeof(BE.Pago)),
                (bllPagoEfectivo.Listar().Cast<object>().ToList(), typeof(BE.PagoEfectivo)),
                (bllPagoTarjeta.Listar().Cast<object>().ToList(), typeof(BE.PagoTarjeta)),
                (bllPedido.Listar().Cast<object>().ToList(), typeof(BE.Pedido)),
                (bllProducto.Listar().Cast<object>().ToList(), typeof(BE.Producto)),
                (bllFactura.Listar().Cast<object>().ToList(), typeof(BE.Factura)),
                (bllItemIngrediente.Listar().Cast<object>().ToList(), typeof(BE.ItemIngrediente)),
                (bllNotaDeEntrega.Listar().Cast<object>().ToList(), typeof(BE.NotaDeEntrega)),
                (bllOrdenDeCompra.Listar().Cast<object>().ToList(), typeof(BE.OrdenDeCompra)),
                (bllPagoInsumo.Listar().Cast<object>().ToList(), typeof(BE.PagoInsumo)),
                (bllProveedor.Listar().Cast<object>().ToList(), typeof(BE.Proveedor)),
                (bllSolicitudDeCotizacion.Listar().Cast<object>().ToList(), typeof(BE.SolicitudDeCotizacion))

            };

            foreach (var (entities, entityType) in entitiesAndColumns)
            {
                var columns = GetMappedColumns(entityType);
                var tableName = GetTableName(entityType);

                for (int i = 0; i < columns.Count; i++)
                {
                    var vectorHASH = ObtenerDV(ConcatenarColumna(entities, columns[i]));
                    var dvv = dVVs.FirstOrDefault(d => d.Tabla == tableName && d.Columna == columns[i]);

                    if (dvv != null)
                    {
                        dvv.DV = vectorHASH;
                        Actualizar(dvv);
                    }
                    else
                    {
                        dvv = new Services.DVV
                        {
                            Tabla = tableName,
                            Columna = columns[i],
                            DV = vectorHASH
                        };
                        Insertar(dvv);
                    }
                }
            }

        }


        public static void Recalcular(List<object> entities, Type entityType)
        {
            List<Services.DVV> dVVs = Listar();

            
            var columns = GetMappedColumns(entityType);
            var tableName = GetTableName(entityType);

            for (int i = 0; i < columns.Count; i++)
            {
                var vectorHASH = ObtenerDV(ConcatenarColumna(entities, columns[i]));
                var dvv = dVVs.FirstOrDefault(d => d.Tabla == tableName && d.Columna == columns[i]);

                if (dvv != null)
                {
                    dvv.DV = vectorHASH;
                    Actualizar(dvv);
                }
                else
                {
                    dvv = new Services.DVV
                    {
                        Tabla = tableName,
                        Columna = columns[i],
                        DV = vectorHASH
                    };
                    Insertar(dvv);
                }
            }
            

        }

        public static List<ColumnaInvalida> ValidarDigitoVerificador()
        {
            List<Services.DVV> dVVs = Listar();
            List<ColumnaInvalida> columnasInvalidas = new List<ColumnaInvalida>();

            var entitiesAndColumns = new List<(List<object> entities, Type entityType)>
            {
                (bllCliente.Listar().Cast<object>().ToList(), typeof(BE.Cliente)),
                (bllComanda.Listar().Cast<object>().ToList(), typeof(BE.Comanda)),
                (bllIngrediente.Listar().Cast<object>().ToList(), typeof(BE.Ingrediente)),
                (bllItemProducto.Listar().Cast<object>().ToList(), typeof(BE.ItemProducto)),
                (bllMetodoDePago.Listar().Cast<object>().ToList(), typeof(BE.MetodoDePago)),
                (bllPago.Listar().Cast<object>().ToList(), typeof(BE.Pago)),
                (bllPagoEfectivo.Listar().Cast<object>().ToList(), typeof(BE.PagoEfectivo)),
                (bllPagoTarjeta.Listar().Cast<object>().ToList(), typeof(BE.PagoTarjeta)),
                (bllPedido.Listar().Cast<object>().ToList(), typeof(BE.Pedido)),
                (bllProducto.Listar().Cast<object>().ToList(), typeof(BE.Producto)),
                (bllFactura.Listar().Cast<object>().ToList(), typeof(BE.Factura)),
                (bllItemIngrediente.Listar().Cast<object>().ToList(), typeof(BE.ItemIngrediente)),
                (bllNotaDeEntrega.Listar().Cast<object>().ToList(), typeof(BE.NotaDeEntrega)),
                (bllOrdenDeCompra.Listar().Cast<object>().ToList(), typeof(BE.OrdenDeCompra)),
                (bllPagoInsumo.Listar().Cast<object>().ToList(), typeof(BE.PagoInsumo)),
                (bllProveedor.Listar().Cast<object>().ToList(), typeof(BE.Proveedor)),
                (bllSolicitudDeCotizacion.Listar().Cast<object>().ToList(), typeof(BE.SolicitudDeCotizacion))

            };

            foreach (var (entities, entityType) in entitiesAndColumns)
            {
                var columns = GetMappedColumns(entityType);

                for (int i = 0; i < columns.Count; i++)
                {
                    var vectorHASH = ObtenerDV(ConcatenarColumna(entities, columns[i]));
                    var dvv = dVVs.FirstOrDefault(d => d.Tabla == entityType.Name.ToUpper() && d.Columna == columns[i]);

                    if (dvv != null && vectorHASH != dvv.DV)
                    {
                        columnasInvalidas.Add(new ColumnaInvalida { Dvv = dvv, Estado = "Modificada" });
                    }
                    else if (dvv == null)
                    {
                        columnasInvalidas.Add(new ColumnaInvalida
                        {
                            Dvv = new Services.DVV { Tabla = entityType.Name.ToUpper(), Columna = columns[i], DV = vectorHASH },
                            Estado = "Eliminada"
                        });
                    }
                }
            }

            return columnasInvalidas;
        }


    }
}
