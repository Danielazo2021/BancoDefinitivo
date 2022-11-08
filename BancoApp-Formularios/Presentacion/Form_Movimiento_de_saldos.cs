﻿using Banco_BibliotecaDDL.Dominio;
using Banco_BibliotecaDDL.Servicios;
using BancoApp_Formularios.HTTP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoApp_Formularios.Presentacion
{
    public partial class Form_Movimiento_de_saldos : Form
    {
        IServicio factory;
        private int dni;
        Cuenta Origen = new Cuenta();
        Cuenta Destino = new Cuenta();
        public Form_Movimiento_de_saldos()
        {
            InitializeComponent();
            factory = new Servicio();
        }

        private  void btnBuscarCuentas_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar el dni");
                return;
            }

            
             actualizarDGV(); 
            ActualizarCboOrigenyDestino();
        }

        private  void actualizarDGV() // hacer un sp que tire las cuentas por dni que ya lo tenemos creo
        {
            dni = Convert.ToInt32(txtDNI.Text);
            dgvCuentas.DataSource = "";

            dgvCuentas.DataSource =  factory.ConsultarCuentasPorDNI(dni);
            dgvCuentas.AutoSize = true;
            dgvCuentas.AutoResizeColumn(4);

        }

        


        private void Form_Movimiento_de_saldos_Load(object sender, EventArgs e)
        {

            //dgv row 4
        }

        private void ActualizarCboOrigenyDestino()
        {
            try
            {
                dni = Convert.ToInt32(txtDNI.Text);
                DataTable DtCbu = factory.ConsultarCuentasPorDNI(dni);
                int tam = DtCbu.Rows.Count;

                double[] ArrCBUOrigen = new double[tam];
                double[] ArrCBUDestino = new double[tam];
                try
                {
                    for (int i = 0; i < (DtCbu.Rows.Count); i++)
                    {

                        ArrCBUOrigen[i] = Convert.ToDouble(DtCbu.Rows[i]["CBU"]);
                        ArrCBUDestino[i] = Convert.ToDouble(DtCbu.Rows[i]["CBU"]);

                    }
                    cboCuentaOrigen.DataSource = ArrCBUOrigen;

                    CboCuentaDestino.DataSource = ArrCBUDestino;
                }

                catch (Exception ex)
                {

                }
            }
            catch (Exception e)
            {

            }

        }

        private void btnActualizarCombos_Click(object sender, EventArgs e)
        {
            ActualizarCboOrigenyDestino();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboCuentaOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cuenta de origen");
                return;
            }
            if (CboCuentaDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cuenta Destino");
                return;
            }
            if (txtImporteaTransferir.Text == "")
            {
                MessageBox.Show("Debe ingresar el monto a transferir");
                return;
            }

            await RealizarTransferencia();


        }

        private async Task RealizarTransferencia()
        {

            //hacer validaciones
            List<Cuenta> Transfer = new List<Cuenta>();

            Origen.Cbu = Convert.ToDouble(cboCuentaOrigen.Text);
            Origen.Saldo = Convert.ToDouble(txtImporteaTransferir.Text);
            Destino.Cbu = Convert.ToDouble(CboCuentaDestino.Text);
            Destino.Saldo = Convert.ToDouble(txtImporteaTransferir.Text);

            Transfer.Add(Origen); // uso saldo, pero es el importe a transferir
            Transfer.Add(Destino);

            // ahora puedo serializar el objeto Transfer para mandar

            string bodyContent = JsonConvert.SerializeObject(Transfer);
            string url = "https://localhost:7224/RealizarTransferencia"; // cmbiar
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);



            if (result.Equals("true"))
            {
                MessageBox.Show("Se realizo la transferencia con exito", "BIEN", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

            }
            else
            {
                MessageBox.Show("Error!!, NO realizo la transferencia", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            cboCuentaOrigen.SelectedIndex = -1;
            CboCuentaDestino.SelectedIndex = -1;
            txtImporteaTransferir.Text = "";


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}