namespace BancoApp_Formularios.Presentacion.Login
{
    partial class Form_Alta_Login
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
            this.btnVolverMenuAnterior = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolverMenuAnterior
            // 
            this.btnVolverMenuAnterior.Location = new System.Drawing.Point(368, 274);
            this.btnVolverMenuAnterior.Name = "btnVolverMenuAnterior";
            this.btnVolverMenuAnterior.Size = new System.Drawing.Size(90, 53);
            this.btnVolverMenuAnterior.TabIndex = 5;
            this.btnVolverMenuAnterior.Text = "Volver al menu anterior";
            this.btnVolverMenuAnterior.UseVisualStyleBackColor = true;
            this.btnVolverMenuAnterior.Click += new System.EventHandler(this.btnVolverMenuAnterior_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(258, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 53);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(143, 274);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 53);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(86, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Por favor ingrese los datos para registrarse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre de usuario";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(258, 159);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtNomUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "DNI";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(258, 203);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 23);
            this.txtPass.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(258, 119);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 0;
            // 
            // Form_Alta_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 410);
            this.Controls.Add(this.btnVolverMenuAnterior);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtDni);
            this.Name = "Form_Alta_Login";
            this.Text = "Form_Alta_Login";
            this.Load += new System.EventHandler(this.Form_Alta_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVolverMenuAnterior;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label4;
        private Label label3;
        private TextBox txtNomUsuario;
        private Label label2;
        private Label label1;
        private TextBox txtPass;
        private TextBox txtDni;
    }
}