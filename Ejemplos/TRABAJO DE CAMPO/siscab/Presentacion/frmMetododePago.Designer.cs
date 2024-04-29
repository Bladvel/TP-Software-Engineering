namespace Presentacion
{
    partial class frmMetododePago
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
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.cb_tarjeta = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_tarjeta = new System.Windows.Forms.Label();
            this.lbl_tarjeta = new System.Windows.Forms.Label();
            this.cb_banco = new System.Windows.Forms.ComboBox();
            this.lbl_banco = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_numerotarjeta = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_cuotas = new System.Windows.Forms.TextBox();
            this.lbl_cuotas = new System.Windows.Forms.Label();
            this.dateTimePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_vencimiento = new System.Windows.Forms.Label();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_nroFactura = new System.Windows.Forms.Label();
            this.txt_numeroFactura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(7, 59);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(94, 23);
            this.cb_tipo.TabIndex = 0;
            // 
            // cb_tarjeta
            // 
            this.cb_tarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tarjeta.FormattingEnabled = true;
            this.cb_tarjeta.Location = new System.Drawing.Point(119, 58);
            this.cb_tarjeta.Name = "cb_tarjeta";
            this.cb_tarjeta.Size = new System.Drawing.Size(109, 23);
            this.cb_tarjeta.TabIndex = 1;
            // 
            // lbl_tipo_tarjeta
            // 
            this.lbl_tipo_tarjeta.AutoSize = true;
            this.lbl_tipo_tarjeta.Location = new System.Drawing.Point(7, 41);
            this.lbl_tipo_tarjeta.Name = "lbl_tipo_tarjeta";
            this.lbl_tipo_tarjeta.Size = new System.Drawing.Size(86, 15);
            this.lbl_tipo_tarjeta.TabIndex = 2;
            this.lbl_tipo_tarjeta.Text = "Tipo de Tarjeta:";
            // 
            // lbl_tarjeta
            // 
            this.lbl_tarjeta.AutoSize = true;
            this.lbl_tarjeta.Location = new System.Drawing.Point(119, 40);
            this.lbl_tarjeta.Name = "lbl_tarjeta";
            this.lbl_tarjeta.Size = new System.Drawing.Size(44, 15);
            this.lbl_tarjeta.TabIndex = 3;
            this.lbl_tarjeta.Text = "Tarjeta:";
            // 
            // cb_banco
            // 
            this.cb_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_banco.FormattingEnabled = true;
            this.cb_banco.Location = new System.Drawing.Point(8, 112);
            this.cb_banco.Name = "cb_banco";
            this.cb_banco.Size = new System.Drawing.Size(220, 23);
            this.cb_banco.TabIndex = 4;
            // 
            // lbl_banco
            // 
            this.lbl_banco.AutoSize = true;
            this.lbl_banco.Location = new System.Drawing.Point(8, 94);
            this.lbl_banco.Name = "lbl_banco";
            this.lbl_banco.Size = new System.Drawing.Size(43, 15);
            this.lbl_banco.TabIndex = 5;
            this.lbl_banco.Text = "Banco:";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(9, 147);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(107, 15);
            this.lbl_numero.TabIndex = 6;
            this.lbl_numero.Text = "Número de Tarjeta:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(157, 147);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(49, 15);
            this.lbl_codigo.TabIndex = 7;
            this.lbl_codigo.Text = "Código:";
            // 
            // txt_numerotarjeta
            // 
            this.txt_numerotarjeta.Location = new System.Drawing.Point(9, 165);
            this.txt_numerotarjeta.MaxLength = 16;
            this.txt_numerotarjeta.Name = "txt_numerotarjeta";
            this.txt_numerotarjeta.Size = new System.Drawing.Size(121, 23);
            this.txt_numerotarjeta.TabIndex = 8;
            this.txt_numerotarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numerotarjeta_KeyPress);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(157, 165);
            this.txt_codigo.MaxLength = 3;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(36, 23);
            this.txt_codigo.TabIndex = 9;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_cuotas
            // 
            this.txt_cuotas.Location = new System.Drawing.Point(157, 215);
            this.txt_cuotas.Name = "txt_cuotas";
            this.txt_cuotas.Size = new System.Drawing.Size(36, 23);
            this.txt_cuotas.TabIndex = 10;
            this.txt_cuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuotas_KeyPress);
            // 
            // lbl_cuotas
            // 
            this.lbl_cuotas.AutoSize = true;
            this.lbl_cuotas.Location = new System.Drawing.Point(157, 197);
            this.lbl_cuotas.Name = "lbl_cuotas";
            this.lbl_cuotas.Size = new System.Drawing.Size(47, 15);
            this.lbl_cuotas.TabIndex = 11;
            this.lbl_cuotas.Text = "Cuotas:";
            // 
            // dateTimePickerVencimiento
            // 
            this.dateTimePickerVencimiento.CustomFormat = "MM/yy";
            this.dateTimePickerVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerVencimiento.Location = new System.Drawing.Point(11, 215);
            this.dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            this.dateTimePickerVencimiento.Size = new System.Drawing.Size(52, 23);
            this.dateTimePickerVencimiento.TabIndex = 12;
            // 
            // lbl_vencimiento
            // 
            this.lbl_vencimiento.AutoSize = true;
            this.lbl_vencimiento.Location = new System.Drawing.Point(11, 198);
            this.lbl_vencimiento.Name = "lbl_vencimiento";
            this.lbl_vencimiento.Size = new System.Drawing.Size(76, 15);
            this.lbl_vencimiento.TabIndex = 13;
            this.lbl_vencimiento.Text = "Vencimiento:";
            // 
            // btn_facturar
            // 
            this.btn_facturar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_facturar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_facturar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_facturar.Location = new System.Drawing.Point(16, 254);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(93, 31);
            this.btn_facturar.TabIndex = 14;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = false;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salir.Location = new System.Drawing.Point(143, 254);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(93, 31);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_nroFactura
            // 
            this.lbl_nroFactura.AutoSize = true;
            this.lbl_nroFactura.Location = new System.Drawing.Point(7, 17);
            this.lbl_nroFactura.Name = "lbl_nroFactura";
            this.lbl_nroFactura.Size = new System.Drawing.Size(112, 15);
            this.lbl_nroFactura.TabIndex = 16;
            this.lbl_nroFactura.Text = "Número de Factura:";
            // 
            // txt_numeroFactura
            // 
            this.txt_numeroFactura.Location = new System.Drawing.Point(130, 12);
            this.txt_numeroFactura.Name = "txt_numeroFactura";
            this.txt_numeroFactura.ReadOnly = true;
            this.txt_numeroFactura.Size = new System.Drawing.Size(76, 23);
            this.txt_numeroFactura.TabIndex = 17;
            // 
            // frmMetododePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 301);
            this.Controls.Add(this.txt_numeroFactura);
            this.Controls.Add(this.lbl_nroFactura);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_facturar);
            this.Controls.Add(this.lbl_vencimiento);
            this.Controls.Add(this.dateTimePickerVencimiento);
            this.Controls.Add(this.lbl_cuotas);
            this.Controls.Add(this.txt_cuotas);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_numerotarjeta);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_banco);
            this.Controls.Add(this.cb_banco);
            this.Controls.Add(this.lbl_tarjeta);
            this.Controls.Add(this.lbl_tipo_tarjeta);
            this.Controls.Add(this.cb_tarjeta);
            this.Controls.Add(this.cb_tipo);
            this.MaximumSize = new System.Drawing.Size(264, 340);
            this.MinimumSize = new System.Drawing.Size(264, 340);
            this.Name = "frmMetododePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMetododePago";
            this.Load += new System.EventHandler(this.frmMetododePago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_tipo;
        private ComboBox cb_tarjeta;
        private Label lbl_tipo_tarjeta;
        private Label lbl_tarjeta;
        private ComboBox cb_banco;
        private Label lbl_banco;
        private Label lbl_numero;
        private Label lbl_codigo;
        private TextBox txt_numerotarjeta;
        private TextBox txt_codigo;
        private TextBox txt_cuotas;
        private Label lbl_cuotas;
        private DateTimePicker dateTimePickerVencimiento;
        private Label lbl_vencimiento;
        private Button btn_facturar;
        private Button btn_salir;
        private Label lbl_nroFactura;
        private TextBox txt_numeroFactura;
    }
}