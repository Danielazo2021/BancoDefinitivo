namespace BancoApp_Formularios.Presentacion.Formularios_Auxiliares
{
    partial class Form_EstadoCivil
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(109, 239);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 45);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Estado";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(385, 240);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(105, 45);
            this.btnVolverMenu.TabIndex = 5;
            this.btnVolverMenu.Text = "Volver al menu anterior";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(229, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(210, 45);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estado Civil";
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(230, 155);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(121, 23);
            this.cboEstadoCivil.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(364, 34);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(98, 43);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Estado";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(137, 109);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(165, 15);
            this.lblResultado.TabIndex = 19;
            this.lblResultado.Text = "\"\" // resultado de la busqueda";
            // 
            // Form_EstadoCivil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 344);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cboEstadoCivil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnModificar);
            this.Name = "Form_EstadoCivil";
            this.Text = "Form_EstadoCivil";
            this.Load += new System.EventHandler(this.Form_EstadoCivil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnModificar;
        private Button btnVolverMenu;
        private Button btnCancelar;
        private TextBox txtDni;
        private Label label1;
        private Label label2;
        private ComboBox cboEstadoCivil;
        private Button btnConsultar;
        private Label lblResultado;
    }
}