namespace Presentacion
{
    partial class frmSerializacion
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
            listBox_objetos = new ListBox();
            dateTimePicker_MesAño = new DateTimePicker();
            lb_mesaño = new Label();
            btn_consultar = new Button();
            btn_examinar = new Button();
            txt_ruta1 = new TextBox();
            btn_serializar = new Button();
            btn_salir = new Button();
            btn_nuevaConsulta = new Button();
            txt_ruta2 = new TextBox();
            btn_examinar2 = new Button();
            btn_deserializar = new Button();
            SuspendLayout();
            // 
            // listBox_objetos
            // 
            listBox_objetos.FormattingEnabled = true;
            listBox_objetos.ItemHeight = 15;
            listBox_objetos.Location = new Point(14, 168);
            listBox_objetos.Name = "listBox_objetos";
            listBox_objetos.Size = new Size(569, 229);
            listBox_objetos.TabIndex = 0;
            // 
            // dateTimePicker_MesAño
            // 
            dateTimePicker_MesAño.CustomFormat = "MM/yy";
            dateTimePicker_MesAño.Format = DateTimePickerFormat.Custom;
            dateTimePicker_MesAño.Location = new Point(79, 27);
            dateTimePicker_MesAño.Name = "dateTimePicker_MesAño";
            dateTimePicker_MesAño.Size = new Size(70, 23);
            dateTimePicker_MesAño.TabIndex = 1;
            // 
            // lb_mesaño
            // 
            lb_mesaño.AutoSize = true;
            lb_mesaño.Location = new Point(14, 33);
            lb_mesaño.Name = "lb_mesaño";
            lb_mesaño.Size = new Size(59, 15);
            lb_mesaño.TabIndex = 2;
            lb_mesaño.Text = "Mes/Año:";
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(164, 27);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(114, 23);
            btn_consultar.TabIndex = 3;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // btn_examinar
            // 
            btn_examinar.Location = new Point(353, 66);
            btn_examinar.Name = "btn_examinar";
            btn_examinar.Size = new Size(111, 23);
            btn_examinar.TabIndex = 4;
            btn_examinar.Text = "Examinar...";
            btn_examinar.UseVisualStyleBackColor = true;
            btn_examinar.Click += btn_examinar_Click;
            // 
            // txt_ruta1
            // 
            txt_ruta1.Location = new Point(26, 66);
            txt_ruta1.Name = "txt_ruta1";
            txt_ruta1.ReadOnly = true;
            txt_ruta1.Size = new Size(321, 23);
            txt_ruta1.TabIndex = 5;
            // 
            // btn_serializar
            // 
            btn_serializar.Location = new Point(470, 66);
            btn_serializar.Name = "btn_serializar";
            btn_serializar.Size = new Size(111, 23);
            btn_serializar.TabIndex = 6;
            btn_serializar.Text = "Serializar JSON";
            btn_serializar.UseVisualStyleBackColor = true;
            btn_serializar.Click += btn_serializar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(506, 415);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 7;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_nuevaConsulta
            // 
            btn_nuevaConsulta.Location = new Point(284, 25);
            btn_nuevaConsulta.Name = "btn_nuevaConsulta";
            btn_nuevaConsulta.Size = new Size(114, 23);
            btn_nuevaConsulta.TabIndex = 8;
            btn_nuevaConsulta.Text = "Nueva Consulta";
            btn_nuevaConsulta.UseVisualStyleBackColor = true;
            btn_nuevaConsulta.Click += btn_nuevaConsulta_Click;
            // 
            // txt_ruta2
            // 
            txt_ruta2.Location = new Point(26, 108);
            txt_ruta2.Name = "txt_ruta2";
            txt_ruta2.ReadOnly = true;
            txt_ruta2.Size = new Size(321, 23);
            txt_ruta2.TabIndex = 9;
            // 
            // btn_examinar2
            // 
            btn_examinar2.Location = new Point(353, 107);
            btn_examinar2.Name = "btn_examinar2";
            btn_examinar2.Size = new Size(111, 23);
            btn_examinar2.TabIndex = 10;
            btn_examinar2.Text = "Examinar...";
            btn_examinar2.UseVisualStyleBackColor = true;
            btn_examinar2.Click += btn_examinar2_Click;
            // 
            // btn_deserializar
            // 
            btn_deserializar.Location = new Point(470, 108);
            btn_deserializar.Name = "btn_deserializar";
            btn_deserializar.Size = new Size(111, 23);
            btn_deserializar.TabIndex = 11;
            btn_deserializar.Text = "Deserializar JSON";
            btn_deserializar.UseVisualStyleBackColor = true;
            btn_deserializar.Click += btn_deserializar_Click;
            // 
            // frmSerializacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 450);
            Controls.Add(btn_deserializar);
            Controls.Add(btn_examinar2);
            Controls.Add(txt_ruta2);
            Controls.Add(btn_nuevaConsulta);
            Controls.Add(btn_salir);
            Controls.Add(btn_serializar);
            Controls.Add(txt_ruta1);
            Controls.Add(btn_examinar);
            Controls.Add(btn_consultar);
            Controls.Add(lb_mesaño);
            Controls.Add(dateTimePicker_MesAño);
            Controls.Add(listBox_objetos);
            Name = "frmSerializacion";
            Text = "frmSerializacion";
            FormClosing += frmSerializacion_FormClosing;            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_objetos;
        private DateTimePicker dateTimePicker_MesAño;
        private Label lb_mesaño;
        private Button btn_consultar;
        private Button btn_examinar;
        private TextBox txt_ruta1;
        private Button btn_serializar;
        private Button btn_salir;
        private Button btn_nuevaConsulta;
        private TextBox txt_ruta2;
        private Button btn_examinar2;
        private Button btn_deserializar;
    }
}