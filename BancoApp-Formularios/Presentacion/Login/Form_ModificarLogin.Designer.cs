namespace BancoApp_Formularios.Presentacion.Login
{
    partial class Form_ModificarLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolverMenuAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "DNI";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(206, 199);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 23);
            this.txtPass.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(206, 115);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre de usuario";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(206, 155);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtNomUsuario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(112, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingrese los nuevos datos";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(91, 270);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 53);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 53);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnVolverMenuAnterior
            // 
            this.btnVolverMenuAnterior.Location = new System.Drawing.Point(316, 270);
            this.btnVolverMenuAnterior.Name = "btnVolverMenuAnterior";
            this.btnVolverMenuAnterior.Size = new System.Drawing.Size(90, 53);
            this.btnVolverMenuAnterior.TabIndex = 5;
            this.btnVolverMenuAnterior.Text = "Volver al menu anterior";
            this.btnVolverMenuAnterior.UseVisualStyleBackColor = true;
            this.btnVolverMenuAnterior.Click += new System.EventHandler(this.btnVolverMenuAnterior_Click);
            // 
            // Form_ModificarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 352);
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
            this.Name = "Form_ModificarLogin";
            this.Text = "Form_ModificarLogin";
            this.Load += new System.EventHandler(this.Form_ModificarLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtPass;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtNomUsuario;
        private Label label4;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnVolverMenuAnterior;
    }
}