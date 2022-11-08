namespace bacnoApp_winForm
{
    partial class Form_Inicio_de_Sesion
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(80, 227);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(89, 52);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(197, 227);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(89, 52);
            this.btnRegistrarse.TabIndex = 3;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(172, 106);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(172, 144);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 23);
            this.txtPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.Location = new System.Drawing.Point(80, 285);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(89, 44);
            this.btnCambiarPass.TabIndex = 4;
            this.btnCambiarPass.Text = "Cambiar contraseña";
            this.btnCambiarPass.UseVisualStyleBackColor = true;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(197, 285);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(89, 44);
            this.btnEliminarUsuario.TabIndex = 5;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // Form_Inicio_de_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 355);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnCambiarPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form_Inicio_de_Sesion";
            this.Text = "Inicio de sesion";
            this.Load += new System.EventHandler(this.Form_Inicio_de_Sesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIngresar;
        private Button btnRegistrarse;
        private TextBox txtDni;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private Button btnCambiarPass;
        private Button btnEliminarUsuario;
    }
}