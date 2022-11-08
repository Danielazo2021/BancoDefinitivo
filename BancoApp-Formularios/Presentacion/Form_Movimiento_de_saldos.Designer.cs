namespace BancoApp_Formularios.Presentacion
{
    partial class Form_Movimiento_de_saldos
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
            this.cboCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.CboCuentaDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImporteaTransferir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnBuscarCuentas = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCuentaOrigen
            // 
            this.cboCuentaOrigen.FormattingEnabled = true;
            this.cboCuentaOrigen.Location = new System.Drawing.Point(152, 145);
            this.cboCuentaOrigen.Name = "cboCuentaOrigen";
            this.cboCuentaOrigen.Size = new System.Drawing.Size(121, 23);
            this.cboCuentaOrigen.TabIndex = 2;
            // 
            // CboCuentaDestino
            // 
            this.CboCuentaDestino.FormattingEnabled = true;
            this.CboCuentaDestino.Location = new System.Drawing.Point(409, 145);
            this.CboCuentaDestino.Name = "CboCuentaDestino";
            this.CboCuentaDestino.Size = new System.Drawing.Size(121, 23);
            this.CboCuentaDestino.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuenta Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Importe";
            // 
            // txtImporteaTransferir
            // 
            this.txtImporteaTransferir.Location = new System.Drawing.Point(674, 142);
            this.txtImporteaTransferir.Name = "txtImporteaTransferir";
            this.txtImporteaTransferir.Size = new System.Drawing.Size(100, 23);
            this.txtImporteaTransferir.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(751, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Debe seleccionar la cuenta origen, luego destino y el importe a mover entre sus c" +
    "uentas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(152, 87);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 23);
            this.txtDNI.TabIndex = 0;
            // 
            // btnBuscarCuentas
            // 
            this.btnBuscarCuentas.Location = new System.Drawing.Point(293, 86);
            this.btnBuscarCuentas.Name = "btnBuscarCuentas";
            this.btnBuscarCuentas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCuentas.TabIndex = 1;
            this.btnBuscarCuentas.Text = "Buscar cuentas";
            this.btnBuscarCuentas.UseVisualStyleBackColor = true;
            this.btnBuscarCuentas.Click += new System.EventHandler(this.btnBuscarCuentas_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(119, 362);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 51);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Realizar Transferencia";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(293, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 51);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar Transferencia";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(655, 362);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(108, 47);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Volver al Menu Anterior";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(12, 204);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.RowTemplate.Height = 25;
            this.dgvCuentas.Size = new System.Drawing.Size(751, 133);
            this.dgvCuentas.TabIndex = 5;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // Form_Movimiento_de_saldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscarCuentas);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImporteaTransferir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboCuentaDestino);
            this.Controls.Add(this.cboCuentaOrigen);
            this.Name = "Form_Movimiento_de_saldos";
            this.Text = "Form_Movimiento_de_saldos";
            this.Load += new System.EventHandler(this.Form_Movimiento_de_saldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboCuentaOrigen;
        private ComboBox CboCuentaDestino;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtImporteaTransferir;
        private Label label4;
        private Label label5;
        private TextBox txtDNI;
        private Button btnBuscarCuentas;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnCerrar;
        private DataGridView dgvCuentas;
    }
}