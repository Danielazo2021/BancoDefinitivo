namespace BancoApp_Formularios.Presentacion
{
    partial class Form_EquipoDeTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EquipoDeTrabajo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolverMenuAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 687);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVolverMenuAnterior
            // 
            this.btnVolverMenuAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolverMenuAnterior.BackgroundImage")));
            this.btnVolverMenuAnterior.Location = new System.Drawing.Point(26, 21);
            this.btnVolverMenuAnterior.Name = "btnVolverMenuAnterior";
            this.btnVolverMenuAnterior.Size = new System.Drawing.Size(50, 50);
            this.btnVolverMenuAnterior.TabIndex = 6;
            this.btnVolverMenuAnterior.UseVisualStyleBackColor = true;
            this.btnVolverMenuAnterior.Click += new System.EventHandler(this.btnVolverMenuAnterior_Click);
            // 
            // Form_EquipoDeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(183)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnVolverMenuAnterior);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form_EquipoDeTrabajo";
            this.Text = "EquipoDeTrabajo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnVolverMenuAnterior;
    }
}