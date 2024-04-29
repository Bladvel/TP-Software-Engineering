using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmClientes : Form
    {
        private static frmClientes instancia = null;

        public static frmClientes Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new frmClientes();
            }
            return instancia;
        }

            
        public frmClientes()
        {
            InitializeComponent();
           
        }

        private void frmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        public void AjustarFormulario()
        {
            this.gb_abm.Location = new Point(12, 14);
            this.dgv_clientes.Visible = false;
            this.gb_listas.Visible = false;
            this.btn_salir.Location = new Point(462, 220);
            instancia.Size = new Size(605, 319);
            
        }
        

      


        BE.Cliente cliente;
        BLL.BLLCliente gestor = new BLL.BLLCliente();
        Bitacora registroBitacora = new Bitacora();
        BLLBitacora gestorBitacora = new BLLBitacora();

        Servicios.ClienteBitacora clienteBitacora;
        BLL.BLLClienteBitacora gestorClienteBIT = new BLL.BLLClienteBitacora();


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_apellido.Text) || string.IsNullOrWhiteSpace(txt_dni.Text) 
                || string.IsNullOrWhiteSpace(txt_telefono_fijo.Text) || string.IsNullOrWhiteSpace(txt_telefono_movil.Text) || string.IsNullOrWhiteSpace(txt_domicilio.Text)
                || string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Complete todos los campos");
            }
            else 
            {
                try
                {
                    cliente = new BE.Cliente();
                    cliente.Nombre = txt_nombre.Text;
                    cliente.Apellido = txt_apellido.Text;
                    cliente.Dni = int.Parse(txt_dni.Text);
                    cliente.Telefono_Fijo = txt_telefono_fijo.Text;
                    cliente.Telefono_Movil = txt_telefono_movil.Text;
                    cliente.Domicilio = txt_domicilio.Text;
                    cliente.Email = txt_email.Text;
                    if (gestor.VerificarClienteExistente(cliente.Dni))
                    {
                        MessageBox.Show("El cliente ya se encuentra registrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        gestor.Grabar(cliente);

                        clienteBitacora = new ClienteBitacora();
                        clienteBitacora.UltimaModificacion = DateTime.Now;
                        clienteBitacora.Activo = 1;
                        clienteBitacora.Tipo = "Agregado";
                        clienteBitacora.Usuario = SingletonSesion.Instancia.Usuario;
                        clienteBitacora.Cliente = cliente;
                        gestorClienteBIT.Insertar(clienteBitacora);

                        ReportarBitacoraAltaCliente();
                        EnlazarActivos();
                        LimpiarTextBox();
                        ControlesInicio();
                    }
                }
                catch (FormatException ex)
                {

                    MessageBox.Show("Formato: " + ex.Source, "Datos con formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void ReportarBitacoraAltaCliente()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Clientes;
            registroBitacora.Operacion = EnumOperacion.Alta;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        private void ReportarBitacoraModificacionCliente()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Clientes;
            registroBitacora.Operacion = EnumOperacion.Modificacion;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        private void ReportarBitacoraConsultarCliente()
        {
            registroBitacora.Fecha = DateTime.Now;
            registroBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            registroBitacora.Modulo = EnumModulo.Clientes;
            registroBitacora.Operacion = EnumOperacion.Consulta;
            registroBitacora.Criticidad = gestorBitacora.CalcularCriticidad(registroBitacora);
            gestorBitacora.ReportarBitacora(registroBitacora);
        }

        void EnlazarTodos()
        {
            dgv_clientes.DataSource = null;
            List<BE.Cliente> clientes = gestor.ListarTodos();
            dgv_clientes.DataSource = clientes;
            lbl_listados.Text = "Listado seleccionado: Clientes totales : " + clientes.Count();

        }

        void EnlazarActivos()
        {
            dgv_clientes.DataSource = null;
            List<BE.Cliente> clientes= gestor.ListarActivos();
            dgv_clientes.DataSource = clientes;
            lbl_listados.Text = "Listado seleccionado: Clientes activos : " + clientes.Count();
        }
       

        void EnlazarBorrados()
        {
            dgv_clientes.DataSource = null;
            List<BE.Cliente> clientes = gestor.ListarBorrados();
            dgv_clientes.DataSource = clientes;
            lbl_listados.Text = "Listado seleccionado: Clientes de baja : " + clientes.Count();

        }

        void LimpiarTextBox()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_telefono_fijo.Text = "";
            txt_telefono_movil.Text = "";
            txt_domicilio.Text = "";
            txt_email.Text = "";
            txt_nombre.Focus();
        }
        
        void ActivarTextBox()
        {
            txt_nombre.Enabled = true;
            txt_apellido.Enabled = true;
            txt_dni.Enabled = true;
            txt_telefono_fijo.Enabled = true;
            txt_telefono_movil.Enabled = true;
            txt_domicilio.Enabled = true;
            txt_email.Enabled = true ;

        }


        void BotonesGrilla()
        {
            btn_agregar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_borrar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        void ControlesInicio()
        {
            btn_nuevo.Enabled = true;
            btn_agregar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_borrar.Enabled = false;
            btn_cancelar.Enabled = false;
            LimpiarTextBox();
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;   
            txt_dni.Enabled = false;
            txt_telefono_fijo.Enabled = false;
            txt_telefono_movil.Enabled = false;
            txt_domicilio.Enabled=false;
            txt_email.Enabled = false;
        }


        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente = (BE.Cliente)dgv_clientes.Rows[e.RowIndex].DataBoundItem;
            ActivarTextBox();
            BotonesGrilla();
            txt_nombre.Text = cliente.Nombre;
            txt_apellido.Text = cliente.Apellido;
            txt_dni.Text = Convert.ToString(cliente.Dni);
            txt_telefono_fijo.Text = cliente.Telefono_Fijo;
            txt_telefono_movil.Text = cliente.Telefono_Movil;
            txt_domicilio.Text= cliente.Domicilio;
            txt_email.Text = cliente.Email;

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            EnlazarActivos();
            ControlesInicio();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            ActivarTextBox();
            LimpiarTextBox();
            btn_agregar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_borrar.Enabled = false;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            
            cliente.Nombre = txt_nombre.Text;
            cliente.Apellido = txt_apellido.Text;
            cliente.Dni = int.Parse(txt_dni.Text);
            cliente.Telefono_Fijo = txt_telefono_fijo.Text;
            cliente.Telefono_Movil = txt_telefono_movil.Text;
            cliente.Domicilio = txt_domicilio.Text;
            cliente.Email = txt_email.Text;                                  
            gestor.Grabar(cliente);

            clienteBitacora = new ClienteBitacora();
            clienteBitacora.UltimaModificacion = DateTime.Now;
            clienteBitacora.Activo = 1;
            clienteBitacora.Tipo = "Modificado";
            clienteBitacora.Usuario = SingletonSesion.Instancia.Usuario;
            clienteBitacora.Cliente = cliente;
            gestorClienteBIT.Desactivar(cliente.Dni);
            gestorClienteBIT.Insertar(clienteBitacora);
            
            ControlesInicio();
            EnlazarActivos();
            ReportarBitacoraModificacionCliente();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            cliente.Borrado = 1;
            gestor.Grabar(cliente);
            ControlesInicio();
            EnlazarActivos();

        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            EnlazarTodos();
            ReportarBitacoraConsultarCliente();

            
        }

        private void btn_borrados_Click(object sender, EventArgs e)
        {
            EnlazarBorrados();
            ReportarBitacoraConsultarCliente();
        }

        private void btn_activos_Click(object sender, EventArgs e)
        {
            EnlazarActivos();
            ReportarBitacoraConsultarCliente();
        }
    }
}
