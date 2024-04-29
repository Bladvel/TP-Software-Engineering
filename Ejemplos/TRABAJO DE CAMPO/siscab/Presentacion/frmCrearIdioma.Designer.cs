namespace Presentacion
{
    partial class frmCrearIdioma
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
            dgv_traducciones = new DataGridView();
            cb_idiomas = new ComboBox();
            lbl_idioma = new Label();
            btn_mostrar = new Button();
            btn_salir = new Button();
            lbl_nuevoIdioma = new Label();
            txt_nuevoIdioma = new TextBox();
            btn_crear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_traducciones).BeginInit();
            SuspendLayout();
            // 
            // dgv_traducciones
            // 
            dgv_traducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_traducciones.Location = new Point(25, 80);
            dgv_traducciones.Name = "dgv_traducciones";
            dgv_traducciones.RowTemplate.Height = 25;
            dgv_traducciones.Size = new Size(611, 244);
            dgv_traducciones.TabIndex = 0;
            // 
            // cb_idiomas
            // 
            cb_idiomas.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_idiomas.FormattingEnabled = true;
            cb_idiomas.Location = new Point(75, 26);
            cb_idiomas.Name = "cb_idiomas";
            cb_idiomas.Size = new Size(83, 23);
            cb_idiomas.TabIndex = 1;
            // 
            // lbl_idioma
            // 
            lbl_idioma.AutoSize = true;
            lbl_idioma.Location = new Point(25, 34);
            lbl_idioma.Name = "lbl_idioma";
            lbl_idioma.Size = new Size(44, 15);
            lbl_idioma.TabIndex = 2;
            lbl_idioma.Tag = "lbl_idioma";
            lbl_idioma.Text = "Idioma";
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(164, 26);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(84, 23);
            btn_mostrar.TabIndex = 3;
            btn_mostrar.Tag = "btn_mostrar";
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(544, 330);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(92, 33);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // lbl_nuevoIdioma
            // 
            lbl_nuevoIdioma.AutoSize = true;
            lbl_nuevoIdioma.Location = new Point(25, 344);
            lbl_nuevoIdioma.Name = "lbl_nuevoIdioma";
            lbl_nuevoIdioma.Size = new Size(85, 15);
            lbl_nuevoIdioma.TabIndex = 5;
            lbl_nuevoIdioma.Text = "Nuevo Idioma:";
            // 
            // txt_nuevoIdioma
            // 
            txt_nuevoIdioma.Location = new Point(109, 336);
            txt_nuevoIdioma.Name = "txt_nuevoIdioma";
            txt_nuevoIdioma.Size = new Size(139, 23);
            txt_nuevoIdioma.TabIndex = 6;
            // 
            // btn_crear
            // 
            btn_crear.Location = new Point(268, 335);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(84, 23);
            btn_crear.TabIndex = 7;
            btn_crear.Tag = "btn_mostrar";
            btn_crear.Text = "Crear Idioma";
            btn_crear.UseVisualStyleBackColor = true;
            // 
            // frmCrearIdioma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 368);
            Controls.Add(btn_crear);
            Controls.Add(txt_nuevoIdioma);
            Controls.Add(lbl_nuevoIdioma);
            Controls.Add(btn_salir);
            Controls.Add(btn_mostrar);
            Controls.Add(lbl_idioma);
            Controls.Add(cb_idiomas);
            Controls.Add(dgv_traducciones);
            Name = "frmCrearIdioma";
            Text = "frmCrearIdioma";
            FormClosing += frmCrearIdioma_FormClosing;
            Load += frmCrearIdioma_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_traducciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_traducciones;
        private ComboBox cb_idiomas;
        private Label lbl_idioma;
        private Button btn_mostrar;
        private Button btn_salir;
        private Label lbl_nuevoIdioma;
        private TextBox txt_nuevoIdioma;
        private Button btn_crear;
    }
}