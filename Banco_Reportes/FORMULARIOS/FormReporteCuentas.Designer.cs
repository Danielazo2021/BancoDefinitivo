﻿namespace Banco_Reportes.FORMULARIOS
{
    partial class FormReporteCuentas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bancoDBDataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDBDataSet10 = new Banco_Reportes.BancoDBDataSet10();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteCuentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reporteSaldosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtValorDolar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDBDataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteCuentasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSaldosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteCuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bancoDBDataSet10BindingSource
            // 
            this.bancoDBDataSet10BindingSource.DataSource = this.bancoDBDataSet10;
            this.bancoDBDataSet10BindingSource.Position = 0;
            // 
            // bancoDBDataSet10
            // 
            this.bancoDBDataSet10.DataSetName = "BancoDBDataSet10";
            this.bancoDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet11";
            reportDataSource1.Value = this.reporteCuentasBindingSource1;
            reportDataSource2.Name = "DataSet12";
            reportDataSource2.Value = this.reporteSaldosBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Banco_Reportes.FORMULARIOS.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(220, 1);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(580, 549);
            this.reportViewer2.TabIndex = 1;
            // 
            // reporteCuentasBindingSource1
            // 
            this.reporteCuentasBindingSource1.DataSource = typeof(Banco_Reportes.ENTIDADES.ReporteCuentas);
            // 
            // reporteSaldosBindingSource
            // 
            this.reporteSaldosBindingSource.DataSource = typeof(Banco_Reportes.ENTIDADES.ReporteSaldos);
            // 
            // reporteCuentasBindingSource
            // 
            this.reporteCuentasBindingSource.DataSource = typeof(Banco_Reportes.ENTIDADES.ReporteCuentas);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Banco_Reportes.ENTIDADES.ReporteSaldos);
            // 
            // txtValorDolar
            // 
            this.txtValorDolar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDolar.Location = new System.Drawing.Point(18, 57);
            this.txtValorDolar.Name = "txtValorDolar";
            this.txtValorDolar.Size = new System.Drawing.Size(111, 28);
            this.txtValorDolar.TabIndex = 2;
            this.txtValorDolar.TextChanged += new System.EventHandler(this.txtValorDolar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Dolar";
            // 
            // btnCargarReporte
            // 
            this.btnCargarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarReporte.Location = new System.Drawing.Point(18, 91);
            this.btnCargarReporte.Name = "btnCargarReporte";
            this.btnCargarReporte.Size = new System.Drawing.Size(111, 31);
            this.btnCargarReporte.TabIndex = 4;
            this.btnCargarReporte.Text = "Cargar Reporte";
            this.btnCargarReporte.UseVisualStyleBackColor = true;
            this.btnCargarReporte.Click += new System.EventHandler(this.btnCargarReporte_Click);
            // 
            // FormReporteCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.btnCargarReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorDolar);
            this.Controls.Add(this.reportViewer2);
            this.Name = "FormReporteCuentas";
            this.Text = "FormReporteCuentas";
            this.Load += new System.EventHandler(this.FormReporteCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDBDataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteCuentasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSaldosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteCuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bancoDBDataSet10BindingSource;
        private BancoDBDataSet10 bancoDBDataSet10;
        private System.Windows.Forms.BindingSource reporteCuentasBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource reporteCuentasBindingSource1;
        private System.Windows.Forms.BindingSource reporteSaldosBindingSource;
        private System.Windows.Forms.TextBox txtValorDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarReporte;
        //private System.Windows.Forms.BindingSource pa_ReporteCamionesyCargasBindingSource;
        //private DataSet10 DataSet3;
        //private DataSet3TableAdapters.pa_ReporteCamionesyCargasTableAdapter pa_ReporteCamionesyCargasTableAdapter;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}