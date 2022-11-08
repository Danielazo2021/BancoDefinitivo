namespace CRUDbanco
{
    partial class Form_AltaCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProximoCliente = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.CBU = new System.Windows.Forms.Label();
            this.txtcbu = new System.Windows.Forms.TextBox();
            this.txtUltimoMov = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colCbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProximoCliente
            // 
            this.lblProximoCliente.AutoSize = true;
            this.lblProximoCliente.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProximoCliente.Location = new System.Drawing.Point(355, 6);
            this.lblProximoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProximoCliente.Name = "lblProximoCliente";
            this.lblProximoCliente.Size = new System.Drawing.Size(122, 26);
            this.lblProximoCliente.TabIndex = 46;
            this.lblProximoCliente.Text = "Cuenta Nro:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(653, 195);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 38);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // CBU
            // 
            this.CBU.AutoSize = true;
            this.CBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBU.Location = new System.Drawing.Point(518, 73);
            this.CBU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CBU.Name = "CBU";
            this.CBU.Size = new System.Drawing.Size(43, 20);
            this.CBU.TabIndex = 44;
            this.CBU.Text = "CBU";
            // 
            // txtcbu
            // 
            this.txtcbu.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcbu.Location = new System.Drawing.Point(630, 71);
            this.txtcbu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcbu.Name = "txtcbu";
            this.txtcbu.Size = new System.Drawing.Size(245, 25);
            this.txtcbu.TabIndex = 6;
            // 
            // txtUltimoMov
            // 
            this.txtUltimoMov.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUltimoMov.Location = new System.Drawing.Point(630, 148);
            this.txtUltimoMov.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUltimoMov.Name = "txtUltimoMov";
            this.txtUltimoMov.Size = new System.Drawing.Size(245, 25);
            this.txtUltimoMov.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(500, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ultimo mov.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(520, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaldo.Location = new System.Drawing.Point(630, 110);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(245, 25);
            this.txtSaldo.TabIndex = 7;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCbu,
            this.SALDO,
            this.colTipo,
            this.UltimoMovimiento,
            this.colAccion});
            this.dgvClientes.Location = new System.Drawing.Point(5, 255);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(920, 103);
            this.dgvClientes.TabIndex = 10;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // colCbu
            // 
            this.colCbu.HeaderText = "cbu";
            this.colCbu.Name = "colCbu";
            this.colCbu.ReadOnly = true;
            // 
            // SALDO
            // 
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            this.SALDO.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo cuenta";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // UltimoMovimiento
            // 
            this.UltimoMovimiento.HeaderText = "ULTIMO MOVIMIENTO";
            this.UltimoMovimiento.Name = "UltimoMovimiento";
            this.UltimoMovimiento.ReadOnly = true;
            // 
            // colAccion
            // 
            this.colAccion.HeaderText = "Accion";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Text = "Eliminar";
            this.colAccion.UseColumnTextForButtonValue = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(342, 366);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(198, 42);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(685, 366);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 42);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(634, 33);
            this.cboTipoCuenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(248, 26);
            this.cboTipoCuenta.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(139, 107);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(248, 25);
            this.txtDni.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(500, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipo cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(139, 68);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(248, 25);
            this.txtApellido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(139, 31);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 25);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 48;
            this.label8.Text = "Estado Civil";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMail.Location = new System.Drawing.Point(139, 143);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(248, 25);
            this.txtMail.TabIndex = 3;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(139, 181);
            this.cboEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(248, 26);
            this.cboEstadoCivil.TabIndex = 4;
            // 
            // Form_AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(954, 420);
            this.Controls.Add(this.cboEstadoCivil);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblProximoCliente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.CBU);
            this.Controls.Add(this.txtcbu);
            this.Controls.Add(this.txtUltimoMov);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_AltaCliente";
            this.Text = "Formulario Cliente";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProximoCliente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label CBU;
        private System.Windows.Forms.TextBox txtcbu;
        private System.Windows.Forms.TextBox txtUltimoMov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private DataGridViewTextBoxColumn colCbu;
        private DataGridViewTextBoxColumn SALDO;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn UltimoMovimiento;
        private DataGridViewButtonColumn colAccion;
        private Label label7;
        private Label label8;
        private TextBox txtMail;
        private ComboBox cboEstadoCivil;
    }
}

