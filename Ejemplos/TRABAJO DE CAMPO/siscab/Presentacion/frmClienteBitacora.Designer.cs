namespace Presentacion
{
    partial class frmClienteBitacora
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
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.dgv_clientesBIT = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_marcar = new System.Windows.Forms.Button();
            this.dateTimePicker_Desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientesBIT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(26, 25);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(67, 15);
            this.lbl_dni.TabIndex = 0;
            this.lbl_dni.Text = "DNI Cliente";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(99, 17);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(82, 23);
            this.txt_dni.TabIndex = 1;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // dgv_clientesBIT
            // 
            this.dgv_clientesBIT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_clientesBIT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientesBIT.Location = new System.Drawing.Point(17, 69);
            this.dgv_clientesBIT.Name = "dgv_clientesBIT";
            this.dgv_clientesBIT.RowTemplate.Height = 25;
            this.dgv_clientesBIT.Size = new System.Drawing.Size(1053, 353);
            this.dgv_clientesBIT.TabIndex = 2;
            this.dgv_clientesBIT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientesBIT_CellClick);
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_consultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_consultar.ForeColor = System.Drawing.Color.White;
            this.btn_consultar.Location = new System.Drawing.Point(199, 16);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(110, 26);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_salir.Location = new System.Drawing.Point(968, 428);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(102, 30);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_listar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listar.ForeColor = System.Drawing.Color.White;
            this.btn_listar.Location = new System.Drawing.Point(519, 31);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(110, 26);
            this.btn_listar.TabIndex = 5;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = false;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_marcar
            // 
            this.btn_marcar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_marcar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_marcar.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_marcar.Location = new System.Drawing.Point(17, 428);
            this.btn_marcar.Name = "btn_marcar";
            this.btn_marcar.Size = new System.Drawing.Size(158, 30);
            this.btn_marcar.TabIndex = 6;
            this.btn_marcar.Text = "Marcar como activo";
            this.btn_marcar.UseVisualStyleBackColor = false;
            this.btn_marcar.Click += new System.EventHandler(this.btn_marcar_Click);
            // 
            // dateTimePicker_Desde
            // 
            this.dateTimePicker_Desde.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Desde.Location = new System.Drawing.Point(102, 33);
            this.dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            this.dateTimePicker_Desde.Size = new System.Drawing.Size(142, 23);
            this.dateTimePicker_Desde.TabIndex = 7;
            // 
            // dateTimePicker_Hasta
            // 
            this.dateTimePicker_Hasta.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Hasta.Location = new System.Drawing.Point(347, 33);
            this.dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            this.dateTimePicker_Hasta.Size = new System.Drawing.Size(154, 23);
            this.dateTimePicker_Hasta.TabIndex = 8;
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(21, 39);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(75, 15);
            this.lbl_desde.TabIndex = 9;
            this.lbl_desde.Text = "Fecha desde:";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(266, 39);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(72, 15);
            this.lbl_hasta.TabIndex = 10;
            this.lbl_hasta.Text = "Fecha hasta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.lbl_dni);
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Location = new System.Drawing.Point(755, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 48);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta por DNI";
            // 
            // frmClienteBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.lbl_desde);
            this.Controls.Add(this.dateTimePicker_Hasta);
            this.Controls.Add(this.dateTimePicker_Desde);
            this.Controls.Add(this.btn_marcar);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dgv_clientesBIT);
            this.Name = "frmClienteBitacora";
            this.Text = "frmClienteBitacora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClienteBitacora_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientesBIT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_dni;
        private TextBox txt_dni;
        private DataGridView dgv_clientesBIT;
        private Button btn_consultar;
        private Button btn_salir;
        private Button btn_listar;
        private Button btn_marcar;
        private DateTimePicker dateTimePicker_Desde;
        private DateTimePicker dateTimePicker_Hasta;
        private Label lbl_desde;
        private Label lbl_hasta;
        private GroupBox groupBox1;
    }
}