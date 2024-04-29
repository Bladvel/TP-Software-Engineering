namespace Presentacion
{
    partial class frmReporte3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lbl_fechaDesde = new Label();
            lbl_fechaHasta = new Label();
            dateTimePicker_desde = new DateTimePicker();
            dateTimePicker_hasta = new DateTimePicker();
            lbl_fechaReporte = new Label();
            txt_fechaHoy = new TextBox();
            btn_Mostrar = new Button();
            btn_nuevaConsulta = new Button();
            txt_ruta = new TextBox();
            btn_examinar = new Button();
            btn_exportarGrafico = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(12, 59);
            chart1.Name = "chart1";
            chart1.Size = new Size(869, 343);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // lbl_fechaDesde
            // 
            lbl_fechaDesde.AutoSize = true;
            lbl_fechaDesde.Location = new Point(11, 28);
            lbl_fechaDesde.Name = "lbl_fechaDesde";
            lbl_fechaDesde.Size = new Size(75, 15);
            lbl_fechaDesde.TabIndex = 1;
            lbl_fechaDesde.Text = "Fecha desde:";
            // 
            // lbl_fechaHasta
            // 
            lbl_fechaHasta.AutoSize = true;
            lbl_fechaHasta.Location = new Point(240, 28);
            lbl_fechaHasta.Name = "lbl_fechaHasta";
            lbl_fechaHasta.Size = new Size(75, 15);
            lbl_fechaHasta.TabIndex = 2;
            lbl_fechaHasta.Text = "Fecha desde:";
            // 
            // dateTimePicker_desde
            // 
            dateTimePicker_desde.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker_desde.Format = DateTimePickerFormat.Custom;
            dateTimePicker_desde.Location = new Point(92, 20);
            dateTimePicker_desde.Name = "dateTimePicker_desde";
            dateTimePicker_desde.Size = new Size(142, 23);
            dateTimePicker_desde.TabIndex = 3;
            dateTimePicker_desde.Value = new DateTime(2024, 1, 16, 0, 0, 0, 0);
            // 
            // dateTimePicker_hasta
            // 
            dateTimePicker_hasta.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker_hasta.Format = DateTimePickerFormat.Custom;
            dateTimePicker_hasta.Location = new Point(321, 20);
            dateTimePicker_hasta.Name = "dateTimePicker_hasta";
            dateTimePicker_hasta.Size = new Size(140, 23);
            dateTimePicker_hasta.TabIndex = 4;
            dateTimePicker_hasta.Value = new DateTime(2024, 1, 16, 23, 59, 59, 0);
            // 
            // lbl_fechaReporte
            // 
            lbl_fechaReporte.AutoSize = true;
            lbl_fechaReporte.Location = new Point(734, 28);
            lbl_fechaReporte.Name = "lbl_fechaReporte";
            lbl_fechaReporte.Size = new Size(41, 15);
            lbl_fechaReporte.TabIndex = 5;
            lbl_fechaReporte.Text = "Fecha:";
            // 
            // txt_fechaHoy
            // 
            txt_fechaHoy.Location = new Point(781, 20);
            txt_fechaHoy.Name = "txt_fechaHoy";
            txt_fechaHoy.ReadOnly = true;
            txt_fechaHoy.Size = new Size(100, 23);
            txt_fechaHoy.TabIndex = 6;
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.BackColor = SystemColors.Control;
            btn_Mostrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Mostrar.ForeColor = SystemColors.ControlText;
            btn_Mostrar.Location = new Point(485, 20);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(108, 23);
            btn_Mostrar.TabIndex = 7;
            btn_Mostrar.Text = "Ver Gráfico";
            btn_Mostrar.UseVisualStyleBackColor = false;
            btn_Mostrar.Click += btn_Mostrar_Click;
            // 
            // btn_nuevaConsulta
            // 
            btn_nuevaConsulta.BackColor = SystemColors.ActiveCaptionText;
            btn_nuevaConsulta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevaConsulta.ForeColor = SystemColors.ButtonHighlight;
            btn_nuevaConsulta.Location = new Point(599, 19);
            btn_nuevaConsulta.Name = "btn_nuevaConsulta";
            btn_nuevaConsulta.Size = new Size(108, 23);
            btn_nuevaConsulta.TabIndex = 8;
            btn_nuevaConsulta.Text = "Nueva Consulta";
            btn_nuevaConsulta.UseVisualStyleBackColor = false;
            btn_nuevaConsulta.Click += btn_nuevaConsulta_Click;
            // 
            // txt_ruta
            // 
            txt_ruta.Location = new Point(12, 422);
            txt_ruta.Name = "txt_ruta";
            txt_ruta.ReadOnly = true;
            txt_ruta.Size = new Size(611, 23);
            txt_ruta.TabIndex = 9;
            // 
            // btn_examinar
            // 
            btn_examinar.Location = new Point(647, 424);
            btn_examinar.Name = "btn_examinar";
            btn_examinar.Size = new Size(109, 23);
            btn_examinar.TabIndex = 10;
            btn_examinar.Text = "Examinar...";
            btn_examinar.UseVisualStyleBackColor = true;
            btn_examinar.Click += btn_examinar_Click;
            // 
            // btn_exportarGrafico
            // 
            btn_exportarGrafico.Location = new Point(772, 424);
            btn_exportarGrafico.Name = "btn_exportarGrafico";
            btn_exportarGrafico.Size = new Size(109, 23);
            btn_exportarGrafico.TabIndex = 11;
            btn_exportarGrafico.Text = "Exportar Gráfico";
            btn_exportarGrafico.UseVisualStyleBackColor = true;
            btn_exportarGrafico.Click += btn_exportarGrafico_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(772, 466);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(109, 23);
            btn_salir.TabIndex = 12;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // frmReporte3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 501);
            Controls.Add(btn_salir);
            Controls.Add(btn_exportarGrafico);
            Controls.Add(btn_examinar);
            Controls.Add(txt_ruta);
            Controls.Add(btn_nuevaConsulta);
            Controls.Add(btn_Mostrar);
            Controls.Add(txt_fechaHoy);
            Controls.Add(lbl_fechaReporte);
            Controls.Add(dateTimePicker_hasta);
            Controls.Add(dateTimePicker_desde);
            Controls.Add(lbl_fechaHasta);
            Controls.Add(lbl_fechaDesde);
            Controls.Add(chart1);
            Name = "frmReporte3";
            Text = "frmReporte3";
            FormClosing += frmReporte3_FormClosing;
            Load += frmReporte3_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label lbl_fechaDesde;
        private Label lbl_fechaHasta;
        private DateTimePicker dateTimePicker_desde;
        private DateTimePicker dateTimePicker_hasta;
        private Label lbl_fechaReporte;
        private TextBox txt_fechaHoy;
        private Button btn_Mostrar;
        private Button btn_nuevaConsulta;
        private TextBox txt_ruta;
        private Button btn_examinar;
        private Button btn_exportarGrafico;
        private Button btn_salir;
    }
}