namespace CRUDbanco.Presentacion
{
    partial class Form_MostrarDatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMostrarCliente = new System.Windows.Forms.DataGridView();
            this.btnNuevaCuenta = new System.Windows.Forms.Button();
            this.btnBajaCuenta = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarCliente
            // 
            this.dgvMostrarCliente.AllowUserToAddRows = false;
            this.dgvMostrarCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarCliente.Location = new System.Drawing.Point(13, 143);
            this.dgvMostrarCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMostrarCliente.Name = "dgvMostrarCliente";
            this.dgvMostrarCliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMostrarCliente.Size = new System.Drawing.Size(891, 173);
            this.dgvMostrarCliente.TabIndex = 2;
            // 
            // btnNuevaCuenta
            // 
            this.btnNuevaCuenta.Location = new System.Drawing.Point(71, 337);
            this.btnNuevaCuenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevaCuenta.Name = "btnNuevaCuenta";
            this.btnNuevaCuenta.Size = new System.Drawing.Size(192, 50);
            this.btnNuevaCuenta.TabIndex = 3;
            this.btnNuevaCuenta.Text = "Asociar nueva cuenta";
            this.btnNuevaCuenta.UseVisualStyleBackColor = true;
            this.btnNuevaCuenta.Click += new System.EventHandler(this.btnNuevaCuenta_Click);
            // 
            // btnBajaCuenta
            // 
            this.btnBajaCuenta.Location = new System.Drawing.Point(662, 337);
            this.btnBajaCuenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBajaCuenta.Name = "btnBajaCuenta";
            this.btnBajaCuenta.Size = new System.Drawing.Size(192, 50);
            this.btnBajaCuenta.TabIndex = 5;
            this.btnBajaCuenta.Text = "Baja cuenta Seleccionada";
            this.btnBajaCuenta.UseVisualStyleBackColor = true;
            this.btnBajaCuenta.Click += new System.EventHandler(this.btnBajaCuenta_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(184, 42);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(116, 23);
            this.txtDni.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI cliente";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(175, 87);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 32);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(348, 337);
            this.btnTransferencia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(192, 50);
            this.btnTransferencia.TabIndex = 4;
            this.btnTransferencia.Text = "Realizar Transferencia de saldo";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // Form_MostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 415);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnBajaCuenta);
            this.Controls.Add(this.btnNuevaCuenta);
            this.Controls.Add(this.dgvMostrarCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_MostrarDatos";
            this.Text = "MostrarDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarCliente;
        private System.Windows.Forms.Button btnNuevaCuenta;
        private System.Windows.Forms.Button btnBajaCuenta;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private Button btnTransferencia;
    }
}