namespace BancoApp_Formularios.Presentacion.Formularios_Auxiliares
{
    partial class Form_DatosDeContacto
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnModificarMail = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(356, 30);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(120, 44);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Mail de Contacto";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Direccion de mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(190, 41);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 248);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(371, 248);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(105, 45);
            this.btnVolverMenu.TabIndex = 5;
            this.btnVolverMenu.Text = "Volver al menu anterior";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btnModificarMail
            // 
            this.btnModificarMail.Location = new System.Drawing.Point(356, 148);
            this.btnModificarMail.Name = "btnModificarMail";
            this.btnModificarMail.Size = new System.Drawing.Size(96, 45);
            this.btnModificarMail.TabIndex = 3;
            this.btnModificarMail.Text = "Modificar Mail";
            this.btnModificarMail.UseVisualStyleBackColor = true;
            this.btnModificarMail.Click += new System.EventHandler(this.btnModificarMail_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(190, 160);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 23);
            this.txtMail.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(104, 88);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(165, 15);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "\"\" // resultado de la busqueda";
            // 
            // Form_DatosDeContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 337);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnModificarMail);
            this.Name = "Form_DatosDeContacto";
            this.Text = "Form_DatosDeContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConsultar;
        private Label label2;
        private Label label1;
        private TextBox txtDni;
        private Button btnCancelar;
        private Button btnVolverMenu;
        private Button btnModificarMail;
        private TextBox txtMail;
        private Label lblResultado;
    }
}