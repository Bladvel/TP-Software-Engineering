using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Interfaces;
using Cliente = BE.Cliente;
using User = BE.User;
using System.IO;
using System.Xml.Serialization;

namespace TPRestaurante
{
    public partial class frmMaestroClientes : Form
    {
        public frmMaestroClientes()
        {
            InitializeComponent();
            bllCliente = new BLL.Cliente();
            bitacora = new Services.Bitacora();
            bllBitacora = new BLL.Bitacora();
            bllDvh = new BLL.DVH();
        }

        private BLL.Cliente bllCliente;
        BLL.ModoDelGestor modo = ModoDelGestor.ModoConsulta;
        private Services.Bitacora bitacora;
        private BLL.Bitacora bllBitacora;
        DataTable dtClientes;
        private BLL.DVH bllDvh;

        private void frmMaestroClientes_Load(object sender, EventArgs e)
        {
            grdClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdClientes.MultiSelect = false;

            grdClientes.RowHeadersVisible = false;

            rbActivos.Checked = true;

            ActualizarGrilla();
            CambiarModo(modo);
        }


        void ActualizarGrilla()
        {
            

            List<Cliente> clientes = bllCliente.Listar();

            dtClientes = ConvertirClientesADataTable(clientes);

            AplicarFiltroCheckBoxes(rbActivos.Checked);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoAgregar;
            CambiarModo(modo);
            txtNombre.Focus();
        }

        void CambiarModo(BLL.ModoDelGestor pModo)
        {
            switch (pModo)
            {
                case BLL.ModoDelGestor.ModoConsulta:
                    lblModo.Text = "Modo consulta";
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnAplicar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnSalir.Enabled = true;
                    HabilitarTextboxs(true);
                    break;
                case BLL.ModoDelGestor.ModoAgregar:
                    lblModo.Text = "Modo agregar";
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAplicar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalir.Enabled = true;
                    HabilitarTextboxs(true);

                    break;
                case BLL.ModoDelGestor.ModoModificar:
                    lblModo.Text = "Modo modificar";
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAplicar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalir.Enabled = true;
                    HabilitarTextboxs(true);

                    break;
                case BLL.ModoDelGestor.ModoEliminar:
                    lblModo.Text = "Modo eliminar";
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAplicar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalir.Enabled = true;
                    HabilitarTextboxs(false);
                    break;
                
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoModificar;
            CambiarModo(modo);
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            modo = BLL.ModoDelGestor.ModoEliminar;
            CambiarModo(modo);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Cliente selectedClient = null;
            DataRowView drv = null;

            switch (modo)
            {
                case BLL.ModoDelGestor.ModoConsulta:
                    break;
                case BLL.ModoDelGestor.ModoAgregar:
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string telefono = txtTelefono.Text;

                    if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido) && !string.IsNullOrWhiteSpace(telefono) && int.TryParse(txtDNI.Text, out int dni))
                    {
                        Cliente cliente = new Cliente(nombre, apellido, dni, telefono);
                        if (bllCliente.Insertar(cliente) != -1)
                        {
                            ActualizarGrilla();
                            ResetTextFields();
                            RegistroBitacoraAgregarCliente();

                            bllDvh.Recalcular(bllDvh.Listar(), bllCliente.Listar(), bllCliente.Concatenar, c => c.ID, "CLIENTE");


                            MessageBox.Show("Cliente ingresado exitosamente","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al ingresar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        
                        

                    }
                    else
                    {
                        MessageBox.Show("Complete todos los campos");
                    }
                    break;
                case BLL.ModoDelGestor.ModoModificar:
                    drv = grdClientes.CurrentRow?.DataBoundItem as DataRowView;
                    
                    if (drv != null)
                    {
                        selectedClient = ConvertirRowViewACliente(drv);
                        selectedClient.Nombre = txtNombre.Text;
                        selectedClient.Apellido = txtApellido.Text;
                        selectedClient.Telefono = txtTelefono.Text;
                        selectedClient.DNI = int.Parse(txtDNI.Text);
                        MessageBox.Show(bllCliente.Modificar(selectedClient));
                        bllDvh.Recalcular(bllDvh.Listar(), bllCliente.Listar(), bllCliente.Concatenar, c => c.ID, "CLIENTE");
                        ActualizarGrilla();
                        ResetTextFields();
                        RegistroBitacoraModificarCliente();
                    }
                    else
                    {
                        MessageBox.Show("No hay cliente seleccionado");
                    }
                    break;
                case BLL.ModoDelGestor.ModoEliminar:
                    drv = grdClientes.CurrentRow?.DataBoundItem as DataRowView;
                    

                    if (drv != null)
                    {
                        selectedClient = ConvertirRowViewACliente(drv);
                        DialogResult result = MessageBox.Show(
                            "¿Estás seguro de que deseas eliminar al cliente seleccionado?",
                            "Confirmación de eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show(bllCliente.Eliminar(selectedClient));
                            RegistrarBitacoraEliminarCliente();
                            ActualizarGrilla();
                            bllDvh.Recalcular(bllDvh.Listar(), bllCliente.Listar(), bllCliente.Concatenar, c => c.ID, "CLIENTE");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay cliente seleccionado");
                    }

                    break;
            }
        }

        private void RegistrarBitacoraEliminarCliente()
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = SessionManager.Instance.User as User;
            bitacora.Modulo = TipoModulo.MaestroClientes;
            bitacora.Operacion = TipoOperacion.Baja;
            bitacora.Criticidad = 2;
            bllBitacora.Insertar(bitacora);
        }

        private void RegistroBitacoraModificarCliente()
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = SessionManager.Instance.User as User;
            bitacora.Modulo = TipoModulo.MaestroClientes;
            bitacora.Operacion = TipoOperacion.Modificacion;
            bitacora.Criticidad = 3;
            bllBitacora.Insertar(bitacora);
        }

        private void RegistroBitacoraAgregarCliente()
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = SessionManager.Instance.User as User;
            bitacora.Modulo = TipoModulo.MaestroClientes;
            bitacora.Operacion = TipoOperacion.Alta;
            bitacora.Criticidad = 2;
            bllBitacora.Insertar(bitacora);
        }

        private void ResetTextFields()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetTextFields();
            grdClientes.ClearSelection();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (modo != BLL.ModoDelGestor.ModoConsulta)
            {
                modo = BLL.ModoDelGestor.ModoConsulta;
                CambiarModo(modo);
            }
            else
            {
                Close();
            }
           
        }

        private void grdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modo == ModoDelGestor.ModoModificar)
            {
                var drv = grdClientes.CurrentRow.DataBoundItem as DataRowView;
                var cliente = ConvertirRowViewACliente(drv);
                if (cliente != null)
                {
                    txtNombre.Text = cliente.Nombre;
                    txtApellido.Text = cliente.Apellido;
                    txtDNI.Text = cliente.DNI.ToString();
                    txtTelefono.Text = cliente.Telefono;
                }
            }
        }


        public DataTable ConvertirClientesADataTable(List<Cliente> clientes)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("NOMBRE", typeof(string));
            dt.Columns.Add("APELLIDO", typeof(string));
            dt.Columns.Add("DNI", typeof(int));
            dt.Columns.Add("TELEFONO", typeof(string));
            dt.Columns.Add("ACTIVO", typeof(bool));

            
            foreach (var cliente in clientes)
            {
                DataRow row = dt.NewRow();
                row["ID"] = cliente.ID;
                row["NOMBRE"] = cliente.Nombre;
                row["APELLIDO"] = cliente.Apellido;
                row["DNI"] = cliente.DNI;
                row["TELEFONO"] = cliente.Telefono;
                row["ACTIVO"] = cliente.Activo;
                dt.Rows.Add(row);
            }

            return dt;
        }

        BE.Cliente ConvertirRowViewACliente(DataRowView rowView)
        {
            BE.Cliente cliente = new BE.Cliente();
            cliente.ID = (int)rowView["ID"];
            cliente.Nombre = rowView["NOMBRE"].ToString();
            cliente.Apellido = rowView["APELLIDO"].ToString();
            cliente.DNI = (int)rowView["DNI"];
            cliente.Telefono = rowView["TELEFONO"].ToString();
            cliente.Activo = (bool)rowView["ACTIVO"];
            return cliente;
        }



        private void AplicarFiltroCheckBoxes(bool mostrarSoloActivos)
        {
            if (dtClientes != null)
            {
                DataView dv = new DataView(dtClientes);

                
                if (mostrarSoloActivos)
                {
                    dv.RowFilter = "ACTIVO = 1";
                }
                else
                {
                    dv.RowFilter = string.Empty;
                }

                grdClientes.DataSource = null;
                grdClientes.DataSource = dv;
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                AplicarFiltroCheckBoxes(false);
            }
        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActivos.Checked)
            {
                AplicarFiltroCheckBoxes(true);
            }
        }

        void HabilitarTextboxs(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            txtDNI.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
        }

        private void btnExaminarSerializar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtRutaSerializar.Text = fbd.SelectedPath;
            }
        }

        private void btnExaminarDesserializar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtRutaDesserializar.Text = openFileDialog.FileName;
            }


        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRutaSerializar.Text))
            {
                MessageBox.Show("Debe seleccionar una ruta para guardar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nombre = "\\Clientes_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".xml";
                string ruta = txtRutaSerializar.Text + nombre;
                List<Cliente> clientes = ObtenerClientesDesdeDataGrid();
                SerializationManager.SerializarXml(clientes, ruta);
                
                MessageBox.Show("Clientes serializados correctamente.","Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbXml.Text = File.ReadAllText(ruta);
            }
        }

        

        private List<Cliente> ObtenerClientesDesdeDataGrid()
        {
            List<Cliente> clientes = new List<Cliente>();


            foreach (DataGridViewRow row in grdClientes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    Cliente cliente = new Cliente
                    {
                        DNI = (int)row.Cells["DNI"].Value,
                        Apellido = row.Cells["APELLIDO"].Value.ToString(),
                        Nombre = row.Cells["NOMBRE"].Value.ToString(),
                        Telefono = row.Cells["TELEFONO"].Value.ToString(),
                        ID = (int)row.Cells["ID"].Value,
                        Activo = (bool)row.Cells["ACTIVO"].Value
                    };
                    clientes.Add(cliente);
                }
            }


            return clientes;
        }

        private void btnDesserializar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtRutaDesserializar.Text))
            {
                MessageBox.Show("Debe seleccionar un archivo para deserializar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Cliente> clientes = SerializationManager.DeserializarXml<List<Cliente>>(txtRutaDesserializar.Text);
                dtClientes = ConvertirClientesADataTable(clientes);
                AplicarFiltroCheckBoxes(rbActivos.Checked);
                MessageBox.Show("Clientes deserializados correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbXml.Text = File.ReadAllText(txtRutaDesserializar.Text);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRutaDesserializar.Text = string.Empty;
            txtRutaSerializar.Text = string.Empty;
            rtbXml.Text = string.Empty;

            rbActivos.Checked = true;
            rbTodos.Checked = false;

            ActualizarGrilla();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (modo == ModoDelGestor.ModoConsulta)
                AplicarFiltroTextboxs();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (modo == ModoDelGestor.ModoConsulta)
                AplicarFiltroTextboxs();
            
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (modo == ModoDelGestor.ModoConsulta)
            {
                AplicarFiltroTextboxs();
            }
            
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if(modo == ModoDelGestor.ModoConsulta)
                AplicarFiltroTextboxs();
        }

        private void AplicarFiltroTextboxs()
        {
            
            DataView dv = (DataView)grdClientes.DataSource;

            
            string filtro = "";

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                filtro += $"NOMBRE LIKE '%{txtNombre.Text}%'";
            }

            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"APELLIDO LIKE '%{txtApellido.Text}%'";
            }

            if (!string.IsNullOrEmpty(txtDNI.Text))
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"DNI LIKE '%{txtDNI.Text}%'";
            }

            if (!string.IsNullOrEmpty(txtTelefono.Text))
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"TELEFONO LIKE '%{txtTelefono.Text}%'";
            }

            
            dv.RowFilter = filtro;
        }

    }
}
