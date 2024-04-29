using DAL;
using Org.BouncyCastle.Asn1.Misc;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLBitacora
    {
        private mp_bitacora mapper = new mp_bitacora();

        public List<Servicios.Bitacora> Listar()
        {
            return mapper.Listar();
        }

        public List<Bitacora> Filtrar(DateTime fi, DateTime ff)
        {            
            return mapper.FiltrarBitacora(fi, ff);
        }

        
        public List<Bitacora> Filtrar(DateTime fi, DateTime ff, Usuario usuario)
        {
            List<Bitacora> listaBitacoraTMP1 = new List<Bitacora>();
            listaBitacoraTMP1 = mapper.FiltrarBitacora(fi, ff);
            List<Bitacora> listaBitacoraTMP2 = new List<Bitacora>();
           
            for (int i = 0; i < listaBitacoraTMP1.Count; i++)
            {
                if (listaBitacoraTMP1[i].Usuario.Id == usuario.Id)
                {
                    listaBitacoraTMP2.Add(listaBitacoraTMP1[i]);
                }
            }
            return listaBitacoraTMP2;
        }

        public List<Bitacora> Filtrar(DateTime fi, DateTime ff, EnumModulo modulo)
        {
            List<Bitacora> listaBitacoraTMP1 = new List<Bitacora>();
            listaBitacoraTMP1 = mapper.FiltrarBitacora(fi, ff);
            List<Bitacora> listaBitacoraTMP2 = new List<Bitacora>();

            for (int i = 0; i < listaBitacoraTMP1.Count; i++)
            {
                if (listaBitacoraTMP1[i].Modulo == modulo)
                {
                    listaBitacoraTMP2.Add(listaBitacoraTMP1[i]);
                }
            }
            return listaBitacoraTMP2;
        }


        public List<Bitacora> Filtrar(DateTime fi, DateTime ff, EnumModulo modulo, Usuario usuario)
        {
            List<Bitacora> listaBitacoraTMP1 = new List<Bitacora>();
            listaBitacoraTMP1 = mapper.FiltrarBitacora(fi, ff);
            List<Bitacora> listaBitacoraTMP2 = new List<Bitacora>();

            for (int i = 0; i < listaBitacoraTMP1.Count; i++)
            {
                if (listaBitacoraTMP1[i].Modulo == modulo && listaBitacoraTMP1[i].Usuario.Id == usuario.Id)
                {
                    listaBitacoraTMP2.Add(listaBitacoraTMP1[i]);
                }
            }
            return listaBitacoraTMP2;
        }

        // aca comienza la otra vuelta

        public List<Bitacora> Filtrar(DateTime fi, DateTime ff, int criticidad)
        {
            List<Bitacora> listaBitacoraTMP1 = new List<Bitacora>();
            listaBitacoraTMP1 = mapper.FiltrarBitacora(fi, ff);
            List<Bitacora> listaBitacoraTMP2 = new List<Bitacora>();

            for (int i = 0; i < listaBitacoraTMP1.Count; i++)
            {
                if (listaBitacoraTMP1[i].Criticidad == criticidad)
                {
                    listaBitacoraTMP2.Add(listaBitacoraTMP1[i]);
                }
            }
            return listaBitacoraTMP2;
        }

        public List<Bitacora> Filtrar(DateTime fi, DateTime ff, Usuario usuario, int criticidad)
        {
            List<Bitacora> listaBitacoraTMP1 = new List<Bitacora>();
            listaBitacoraTMP1 = mapper.FiltrarBitacora(fi, ff);
            List<Bitacora> listaBitacoraTMP2 = new List<Bitacora>();

            for (int i = 0; i < listaBitacoraTMP1.Count; i++)
            {
                if (listaBitacoraTMP1[i].Usuario.Id == usuario.Id && listaBitacoraTMP1[i].Criticidad == criticidad)
                {
                    listaBitacoraTMP2.Add(listaBitacoraTMP1[i]);
                }
            }
            return listaBitacoraTMP2;
        }

        public List<Bitacora> Filtrar(DateTime fi, DateTime ff, EnumModulo modulo, int criticidad)
        {
            List<Bitacora> listaBitacoraTMP1 = new List<Bitacora>();
            listaBitacoraTMP1 = mapper.FiltrarBitacora(fi, ff);
            List<Bitacora> listaBitacoraTMP2 = new List<Bitacora>();

            for (int i = 0; i < listaBitacoraTMP1.Count; i++)
            {
                if (listaBitacoraTMP1[i].Modulo == modulo && listaBitacoraTMP1[i].Criticidad == criticidad)
                {
                    listaBitacoraTMP2.Add(listaBitacoraTMP1[i]);
                }
            }
            return listaBitacoraTMP2;
        }


        public List<Bitacora> Filtrar(DateTime fi, DateTime ff, EnumModulo modulo, Usuario usuario, int criticidad)
        {
            List<Bitacora> listaBitacoraTMP1 = new List<Bitacora>();
            listaBitacoraTMP1 = mapper.FiltrarBitacora(fi, ff);
            List<Bitacora> listaBitacoraTMP2 = new List<Bitacora>();

            for (int i = 0; i < listaBitacoraTMP1.Count; i++)
            {
                if (listaBitacoraTMP1[i].Modulo == modulo && listaBitacoraTMP1[i].Usuario.Id == usuario.Id  && listaBitacoraTMP1[i].Criticidad == criticidad)
                {
                    listaBitacoraTMP2.Add(listaBitacoraTMP1[i]);
                }
            }
            return listaBitacoraTMP2;
        }

        public void ReportarBitacora(Servicios.Bitacora bitacora)
        {
            mapper.Insertar(bitacora);
        }

        public int CalcularCriticidad(Servicios.Bitacora bitacora)
        {
            int criticidad = 0;

            if (bitacora.Modulo == Servicios.EnumModulo.Usuarios || bitacora.Modulo == Servicios.EnumModulo.GestorUsuario || bitacora.Modulo == Servicios.EnumModulo.Perfiles)
            {
                criticidad = 1;
            }
            else if (bitacora.Modulo == Servicios.EnumModulo.Clientes || bitacora.Modulo == Servicios.EnumModulo.Habitaciones)
            {
                criticidad = 2;
            }
            else
            {
                criticidad = 3;
            }

            return criticidad;
        }

    }
}
