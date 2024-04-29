namespace Presentacion
{
    partial class frmReporte2
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_fechaDesde = new System.Windows.Forms.Label();
            this.lbl_fechaHasta = new System.Windows.Forms.Label();
            this.dateTimePicker_desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_hasta = new System.Windows.Forms.DateTimePicker();
            this.btn_listar = new System.Windows.Forms.Button();
            this.dataGridView_facturas = new System.Windows.Forms.DataGridView();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.btn_exportarPDF = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_fechaReporte = new System.Windows.Forms.Label();
            this.txt_fechaHoy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(19, 27);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(373, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Reporte de Facturación de los Checkouts";
            // 
            // lbl_fechaDesde
            // 
            this.lbl_fechaDesde.AutoSize = true;
            this.lbl_fechaDesde.Location = new System.Drawing.Point(24, 70);
            this.lbl_fechaDesde.Name = "lbl_fechaDesde";
            this.lbl_fechaDesde.Size = new System.Drawing.Size(75, 15);
            this.lbl_fechaDesde.TabIndex = 1;
            this.lbl_fechaDesde.Text = "Fecha desde:";
            // 
            // lbl_fechaHasta
            // 
            this.lbl_fechaHasta.AutoSize = true;
            this.lbl_fechaHasta.Location = new System.Drawing.Point(298, 68);
            this.lbl_fechaHasta.Name = "lbl_fechaHasta";
            this.lbl_fechaHasta.Size = new System.Drawing.Size(72, 15);
            this.lbl_fechaHasta.TabIndex = 2;
            this.lbl_fechaHasta.Text = "Fecha hasta:";
            // 
            // dateTimePicker_desde
            // 
            this.dateTimePicker_desde.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_desde.Location = new System.Drawing.Point(105, 62);
            this.dateTimePicker_desde.Name = "dateTimePicker_desde";
            this.dateTimePicker_desde.Size = new System.Drawing.Size(144, 23);
            this.dateTimePicker_desde.TabIndex = 3;
            this.dateTimePicker_desde.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // dateTimePicker_hasta
            // 
            this.dateTimePicker_hasta.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_hasta.Location = new System.Drawing.Point(377, 62);
            this.dateTimePicker_hasta.Name = "dateTimePicker_hasta";
            this.dateTimePicker_hasta.Size = new System.Drawing.Size(144, 23);
            this.dateTimePicker_hasta.TabIndex = 4;
            this.dateTimePicker_hasta.Value = new System.DateTime(2023, 12, 4, 23, 59, 59, 0);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(556, 62);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(90, 23);
            this.btn_listar.TabIndex = 5;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // dataGridView_facturas
            // 
            this.dataGridView_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_facturas.Location = new System.Drawing.Point(26, 134);
            this.dataGridView_facturas.Name = "dataGridView_facturas";
            this.dataGridView_facturas.RowTemplate.Height = 25;
            this.dataGridView_facturas.Size = new System.Drawing.Size(620, 190);
            this.dataGridView_facturas.TabIndex = 6;
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(24, 104);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.ReadOnly = true;
            this.txt_ruta.Size = new System.Drawing.Size(416, 23);
            this.txt_ruta.TabIndex = 7;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Enabled = false;
            this.btn_examinar.Location = new System.Drawing.Point(446, 105);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(75, 23);
            this.btn_examinar.TabIndex = 8;
            this.btn_examinar.Text = "Examinar...";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // btn_exportarPDF
            // 
            this.btn_exportarPDF.Location = new System.Drawing.Point(527, 105);
            this.btn_exportarPDF.Name = "btn_exportarPDF";
            this.btn_exportarPDF.Size = new System.Drawing.Size(119, 23);
            this.btn_exportarPDF.TabIndex = 9;
            this.btn_exportarPDF.Text = "Exportar PDF";
            this.btn_exportarPDF.UseVisualStyleBackColor = true;
            this.btn_exportarPDF.Click += new System.EventHandler(this.btn_exportarPDF_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(24, 347);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(283, 15);
            this.lbl_total.TabIndex = 10;
            this.lbl_total.Text = "Facturación Total de la recaudación de Checkouts: $ ";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(552, 345);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(94, 23);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_fechaReporte
            // 
            this.lbl_fechaReporte.AutoSize = true;
            this.lbl_fechaReporte.Location = new System.Drawing.Point(497, 35);
            this.lbl_fechaReporte.Name = "lbl_fechaReporte";
            this.lbl_fechaReporte.Size = new System.Drawing.Size(41, 15);
            this.lbl_fechaReporte.TabIndex = 12;
            this.lbl_fechaReporte.Text = "Fecha:";
            // 
            // txt_fechaHoy
            // 
            this.txt_fechaHoy.Location = new System.Drawing.Point(544, 28);
            this.txt_fechaHoy.Name = "txt_fechaHoy";
            this.txt_fechaHoy.ReadOnly = true;
            this.txt_fechaHoy.Size = new System.Drawing.Size(74, 23);
            this.txt_fechaHoy.TabIndex = 13;
            // 
            // frmReporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 380);
            this.Controls.Add(this.txt_fechaHoy);
            this.Controls.Add(this.lbl_fechaReporte);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_exportarPDF);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.dataGridView_facturas);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.dateTimePicker_hasta);
            this.Controls.Add(this.dateTimePicker_desde);
            this.Controls.Add(this.lbl_fechaHasta);
            this.Controls.Add(this.lbl_fechaDesde);
            this.Controls.Add(this.lbl_titulo);
            this.MaximumSize = new System.Drawing.Size(686, 419);
            this.MinimumSize = new System.Drawing.Size(686, 419);
            this.Name = "frmReporte2";
            this.Text = "frmReporte2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReporte2_FormClosing);
            this.Load += new System.EventHandler(this.frmReporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_fechaDesde;
        private Label lbl_fechaHasta;
        private DateTimePicker dateTimePicker_desde;
        private DateTimePicker dateTimePicker_hasta;
        private Button btn_listar;
        private DataGridView dataGridView_facturas;
        private TextBox txt_ruta;
        private Button btn_examinar;
        private Button btn_exportarPDF;
        private Label lbl_total;
        private Button btn_salir;
        private Label lbl_fechaReporte;
        private TextBox txt_fechaHoy;
    }
}