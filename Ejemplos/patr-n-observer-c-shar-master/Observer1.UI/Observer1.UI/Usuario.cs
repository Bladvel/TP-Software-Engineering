using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer1.UI
{


    public class Usuario : IObserverUsuario
    {
       
        public Usuario(string nombre,string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }


        public void Actualizar(Producto p)
        {
            Form1 f =(Form1) Application.OpenForms[0];
            f.Notificar($"El usuario {this} recibio la notificacion del producto {p}");
            
    
         }
        
      
    }
}
