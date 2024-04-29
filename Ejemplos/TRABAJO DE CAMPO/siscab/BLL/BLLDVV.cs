using BE;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace BLL
{
    public class BLLDVV
    {
        DAL.mp_DVV mapper = new DAL.mp_DVV();
        DAL.mp_reserva mapperReserva = new DAL.mp_reserva();
        string concID, concFI, concFF, concCLI, concCD, concHAB, concFA;        
        string[] vectorHASH = new string[7];

        public List<DVV> Listar()
        {
            return mapper.Listar();
        }

        public void Insertar(DVV dvv)
        {
            mapper.Insertar(dvv);
        }

        public void ActualizarDigitoVerificador(DVV dvv)
        {
            mapper.Modificar(dvv);
        }
      

        public string ObtenerDigitoVerificador(string cadena)
        {
            string hash;
            hash = Encriptador.Hash(cadena);
            return hash;
        }

        public void ConcatenarEncriptarColumna()
        {
            List<Reserva> reservas = new List<Reserva>();
            reservas = mapperReserva.Listar();

            for (int i = 0; i < reservas.Count; i++)
            {
                concID += reservas[i].Id;
                concFI += reservas[i].Fecha_Inicio;
                concFF += reservas[i].Fecha_Fin;
                concCLI += reservas[i].Cliente.Id;
                concCD += reservas[i].Cantidad_Dias;
                concHAB += reservas[i].Habitacion.Id;
                concFA += reservas[i].Facturada;
            }

            vectorHASH[0] = ObtenerDigitoVerificador(concID);
            vectorHASH[1] = ObtenerDigitoVerificador(concFI);
            vectorHASH[2] = ObtenerDigitoVerificador(concFF);
            vectorHASH[3] = ObtenerDigitoVerificador(concCLI);
            vectorHASH[4] = ObtenerDigitoVerificador(concCD); 
            vectorHASH[5] = ObtenerDigitoVerificador(concHAB);
            vectorHASH[6] = ObtenerDigitoVerificador(concFA);
        }

        public bool ValidarDigitoVerificador()
        {
            bool ok = true;
            List<DVV> dVVs = new List<DVV>();
            dVVs = Listar();

            if (dVVs.Count > 0)
            {
                ConcatenarEncriptarColumna();


                for (int i = 0; i < dVVs.Count; i++)
                {
                    if (vectorHASH[i] != dVVs[i].DV)
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

        public void RecalcularDigitoVerificador()
        {
            List<DVV> dVVs = new List<DVV>();
            dVVs = Listar();
            concID = "";
            concFI = "";
            concFF = "";
            concCLI = "";
            concCD = "";
            concHAB = "";
            concFA = "";

            ConcatenarEncriptarColumna();

            for (int i = 0; i < dVVs.Count; i++)
            {
                dVVs[i].DV = vectorHASH[i];
                ActualizarDigitoVerificador(dVVs[i]);
            }                    
        }
    }
}
