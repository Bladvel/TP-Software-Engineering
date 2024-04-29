using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLReserva
    {
        private DAL.mp_reserva mapper = new DAL.mp_reserva();
        

        public List<BE.Reserva> Listar()
        {
            return mapper.Listar();
        }

        public List<BE.Reserva> ListarReservasSinFacturar()
        {
            List<BE.Reserva> reservasSinFacturar = new List<BE.Reserva>();
            List<BE.Reserva> reservas = new List<BE.Reserva>();
            reservas = Listar();                        
            for (int i = 0; i < reservas.Count; i++)
            {
                if (reservas[i].Facturada == "No")
                {
                    reservasSinFacturar.Add(reservas[i]);
                }
            }
            return reservasSinFacturar;
        }


        public void Insertar(BE.Reserva reserva)
        {                      
            mapper.Insertar(reserva);
        }

       

        public void CalcularCantidadDias(BE.Reserva reserva)
        {
            TimeSpan tspan = reserva.Fecha_Fin - reserva.Fecha_Inicio;
            reserva.Cantidad_Dias = tspan.Days;
        }

        
        public List<Reserva> ListarReservasTipoHabitacion(int c)
        {
            List<Reserva> reservasOcupadas = new List<Reserva>();
            reservasOcupadas = Listar();
            List<Reserva> reservasFiltradas = new List<Reserva>();

            for (int i = 0; i < reservasOcupadas.Count; i++)
            {
                if (reservasOcupadas[i].Cantidad_Huespedes == c)
                {
                    reservasFiltradas.Add(reservasOcupadas[i]);
                }
            }
            return reservasFiltradas;
        }

        public List<Habitacion> FiltrarDisponibilidad(List<Habitacion> habitaciones)
        {
            List<Habitacion> habitacionesFinal = new List<Habitacion>();
            for (int i = 0; i < habitaciones.Count; i++)
            {
                if (habitaciones[i].Disponibilidad == true)
                {
                    habitacionesFinal.Add(habitaciones[i]);
                }                              
            }
            return habitacionesFinal;
        }


        public void Modificar (BE.Reserva reserva)
        {            
             mapper.Modificar(reserva);        
        }



        public List<Habitacion> VerificarDisponibilidad(List<Habitacion> habs, DateTime fi, DateTime ff, int c)
        {
            List<Reserva> reservasOcupadas = new List<Reserva>();
            reservasOcupadas = ListarReservasTipoHabitacion(c);                           
            List<Habitacion> habitacionesOk = new List<Habitacion>();
            if (reservasOcupadas.Count > 0)
            {
                for (int i = 0; i < reservasOcupadas.Count; i++)
                {
                    for (int j = 0; j < habs.Count; j++)
                    {                        
                        if (habs[j].Id == reservasOcupadas[i].Habitacion.Id && habs[j].Disponibilidad == true)
                        {                      
                            if (ff <= reservasOcupadas[i].Fecha_Inicio)
                            {                                                                   
                                 habitacionesOk.Add(habs[j]);
                                
                            }
                            else if (fi >= reservasOcupadas[i].Fecha_Fin)
                            {                                                                                             
                                 habitacionesOk.Add(habs[j]);
                                
                            }
                            else
                            {
                                habs[j].Disponibilidad = false;
                            }                      
                        }
                        else 
                        {                   
                            if (habs[j].Tipo != reservasOcupadas[i].Habitacion.Tipo)
                            {
                                habitacionesOk.Add(habs[j]);
                            }                                                                       
                        }                                                          
                    }
                }
            }
            else
            {
                habitacionesOk = habs;
            }           
            habitacionesOk=FiltrarDisponibilidad(habitacionesOk);
            habitacionesOk = habitacionesOk.Distinct().ToList();
            return habitacionesOk;
        }

        public List<Reserva> FiltrarMesAño (int mes, int año)
        {
            List<Reserva> reservas= new List<Reserva>();
            reservas = Listar();
            List<Reserva> reservasTMP = new List<Reserva>();

            for (int i = 0; i < reservas.Count; i++)
            {
                if ((reservas[i].Fecha_Inicio.Year == año || reservas[i].Fecha_Fin.Year == año) && (reservas[i].Fecha_Inicio.Month == mes || reservas[i].Fecha_Fin.Month == mes))
                {
                    reservasTMP.Add(reservas[i]);
                }
            }
            return reservasTMP;
        }


    }
}
