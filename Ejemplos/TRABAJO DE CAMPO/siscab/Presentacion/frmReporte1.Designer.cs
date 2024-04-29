namespace Presentacion
{
    partial class frmReporte1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_reporte1 = new System.Windows.Forms.DataGridView();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_exportarPDF = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_totalfacturacion = new System.Windows.Forms.Label();
            this.dateTimePicker_desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechadesde = new System.Windows.Forms.Label();
            this.lbl_fechahasta = new System.Windows.Forms.Label();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_fechaHoy = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reporte1
            // 
            this.dgv_reporte1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reporte1.Location = new System.Drawing.Point(12, 130);
            this.dgv_reporte1.Name = "dgv_reporte1";
            this.dgv_reporte1.RowTemplate.Height = 25;
            this.dgv_reporte1.Size = new System.Drawing.Size(642, 196);
            this.dgv_reporte1.TabIndex = 0;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(559, 59);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(95, 24);
            this.btn_listar.TabIndex = 1;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_exportarPDF
            // 
            this.btn_exportarPDF.Location = new System.Drawing.Point(535, 91);
            this.btn_exportarPDF.Name = "btn_exportarPDF";
            this.btn_exportarPDF.Size = new System.Drawing.Size(119, 23);
            this.btn_exportarPDF.TabIndex = 2;
            this.btn_exportarPDF.Text = "Exportar PDF";
            this.btn_exportarPDF.UseVisualStyleBackColor = true;
            this.btn_exportarPDF.Click += new System.EventHandler(this.btn_exportarPDF_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(328, 25);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Reporte de Facturación de Reservas";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(528, 355);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(126, 23);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_totalfacturacion
            // 
            this.lbl_totalfacturacion.AutoSize = true;
            this.lbl_totalfacturacion.Location = new System.Drawing.Point(12, 355);
            this.lbl_totalfacturacion.Name = "lbl_totalfacturacion";
            this.lbl_totalfacturacion.Size = new System.Drawing.Size(182, 15);
            this.lbl_totalfacturacion.TabIndex = 5;
            this.lbl_totalfacturacion.Text = "Facturación Total de depósitos: $ ";
            // 
            // dateTimePicker_desde
            // 
            this.dateTimePicker_desde.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_desde.Location = new System.Drawing.Point(108, 59);
            this.dateTimePicker_desde.Name = "dateTimePicker_desde";
            this.dateTimePicker_desde.Size = new System.Drawing.Size(142, 23);
            this.dateTimePicker_desde.TabIndex = 6;
            this.dateTimePicker_desde.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // dateTimePicker_hasta
            // 
            this.dateTimePicker_hasta.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_hasta.Location = new System.Drawing.Point(346, 59);
            this.dateTimePicker_hasta.Name = "dateTimePicker_hasta";
            this.dateTimePicker_hasta.Size = new System.Drawing.Size(142, 23);
            this.dateTimePicker_hasta.TabIndex = 7;
            this.dateTimePicker_hasta.Value = new System.DateTime(2023, 12, 4, 23, 59, 59, 0);
            // 
            // lbl_fechadesde
            // 
            this.lbl_fechadesde.AutoSize = true;
            this.lbl_fechadesde.Location = new System.Drawing.Point(27, 65);
            this.lbl_fechadesde.Name = "lbl_fechadesde";
            this.lbl_fechadesde.Size = new System.Drawing.Size(75, 15);
            this.lbl_fechadesde.TabIndex = 8;
            this.lbl_fechadesde.Text = "Fecha desde:";
            // 
            // lbl_fechahasta
            // 
            this.lbl_fechahasta.AutoSize = true;
            this.lbl_fechahasta.Location = new System.Drawing.Point(268, 65);
            this.lbl_fechahasta.Name = "lbl_fechahasta";
            this.lbl_fechahasta.Size = new System.Drawing.Size(72, 15);
            this.lbl_fechahasta.TabIndex = 9;
            this.lbl_fechahasta.Text = "Fecha hasta:";
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(27, 92);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.ReadOnly = true;
            this.txt_ruta.Size = new System.Drawing.Size(416, 23);
            this.txt_ruta.TabIndex = 10;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Enabled = false;
            this.btn_examinar.Location = new System.Drawing.Point(454, 91);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(75, 23);
            this.btn_examinar.TabIndex = 11;
            this.btn_examinar.Text = "Examinar...";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_fechaHoy
            // 
            this.txt_fechaHoy.Location = new System.Drawing.Point(558, 11);
            this.txt_fechaHoy.Name = "txt_fechaHoy";
            this.txt_fechaHoy.ReadOnly = true;
            this.txt_fechaHoy.Size = new System.Drawing.Size(74, 23);
            this.txt_fechaHoy.TabIndex = 12;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(511, 19);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(41, 15);
            this.lbl_fecha.TabIndex = 13;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // frmReporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 380);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_fechaHoy);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.lbl_fechahasta);
            this.Controls.Add(this.lbl_fechadesde);
            this.Controls.Add(this.dateTimePicker_hasta);
            this.Controls.Add(this.dateTimePicker_desde);
            this.Controls.Add(this.lbl_totalfacturacion);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_exportarPDF);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.dgv_reporte1);
            this.MaximumSize = new System.Drawing.Size(686, 419);
            this.MinimumSize = new System.Drawing.Size(686, 419);
            this.Name = "frmReporte1";
            this.Text = "frmReporte1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReporte1_FormClosing);
            this.Load += new System.EventHandler(this.frmReporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_reporte1;
        private Button btn_listar;
        private Button btn_exportarPDF;
        private Label lbl_titulo;
        private Button btn_salir;
        private Label lbl_totalfacturacion;
        private DateTimePicker dateTimePicker_desde;
        private DateTimePicker dateTimePicker_hasta;
        private Label lbl_fechadesde;
        private Label lbl_fechahasta;
        private TextBox txt_ruta;
        private Button btn_examinar;
        private TextBox txt_fechaHoy;
        private Label lbl_fecha;
    }
}