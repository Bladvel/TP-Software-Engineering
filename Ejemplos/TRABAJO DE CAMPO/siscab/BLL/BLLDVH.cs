using BE;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLDVH
    {
        DAL.mp_DVH mapper = new DAL.mp_DVH();
        DAL.mp_reserva mapperReserva = new DAL.mp_reserva();


        public List<DVH> Listar()
        {
            return mapper.Listar();
        }

        public void Insertar(DVH dvh)
        {
            mapper.Insertar(dvh);
        }

        public void ActualizarDigitoVerificador(DVH dvh)
        {
            mapper.Modificar(dvh);
        }


        public void BorrarRegistros()
        {
            mapper.BorrarRegistros();
        }


        public string ObtenerDigitoVerificador (string cadena)
        {
            string hash;
            hash = Encriptador.Hash(cadena);
            return hash;
        }

        //faltaria programar el recalcular digito verificador


        public string ConcatenarRegistro(Reserva reserva)
        {            
            var concatenacion = string.Concat(Convert.ToString(reserva.Id) + Convert.ToString(reserva.Fecha_Inicio) +
                 Convert.ToString(reserva.Fecha_Fin) + Convert.ToString(reserva.Cliente.Id) + Convert.ToString(reserva.Habitacion.Id) +
                Convert.ToString(reserva.Cantidad_Huespedes) + Convert.ToString(reserva.Cantidad_Dias) + Convert.ToString(reserva.Facturada));

            return concatenacion;
        }

        public bool ValidarDigitoVerificador()
        {
            bool ok = true;
            List<Reserva> reservas = new List<Reserva>();
            reservas = mapperReserva.Listar();

            List<DVH> dVHs= new List<DVH>();
            dVHs = Listar();

            if (dVHs.Count > 0)
            {
                for (int i = 0; i < reservas.Count; i++)
                {
                    var cadena = ConcatenarRegistro(reservas[i]);
                    var hash = ObtenerDigitoVerificador(cadena);

                    if (hash != dVHs[i].DV)
                    {
                        ok = false;
                    }
                }
            }
            else
            {
                ok = true;
            }
           
            return ok;
        }

        public bool ValidarCantidadRegistros(List<Reserva> reservas, List<DVH> dVHs)
        {
            bool ok = true;
            if (reservas.Count != dVHs.Count)
            {
                ok = false;
            }
            return ok;
        }


        public void RecalcularDigitoVerificador(DVH dvh, List<DVH> lista)
        {
            List<Reserva> reservas = new List<Reserva>();
            reservas = mapperReserva.Listar();

            for (int i = 0; i < reservas.Count; i++)
            {
                string cadena = ConcatenarRegistro(reservas[i]);
                dvh.Modulo = "Reserva";
                dvh.Registro = reservas[i].Id;
                dvh.DV = ObtenerDigitoVerificador(cadena);

                if (lista.Count > 0)
                {
                    ActualizarDigitoVerificador(dvh);
                }
                else
                {
                    Insertar(dvh);
                }               
            }
        }
    }
}
