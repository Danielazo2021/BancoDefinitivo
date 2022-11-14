using Banco_BibliotecaDDL.Dominio;
using Banco_BibliotecaDDL.Servicios;
using BancoApp_Formularios.HTTP;
using BancoApp_Formularios.Presentacion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDbanco.Presentacion
{
    public partial class Form_MostrarDatos : Form
    {
       
        int dni;

        public Form_MostrarDatos()
        {
            InitializeComponent();
            
        }


        private async void btnConsultar_Click_1(object sender, EventArgs e)  
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar el dni");
                return;
            }
            try
            {
                int dni = Convert.ToInt32(txtDni.Text);
            }
            catch
            {
                MessageBox.Show("El DNI no es valido, ingrese un numero de documento");
                return;
            }

            await MostrarDataGridViewAsync();


        }

        private async Task MostrarDataGridViewAsync()
        {
            dni = Convert.ToInt32(txtDni.Text);
            dgvMostrarCliente.DataSource = "";

            //
            string bodyContent = JsonConvert.SerializeObject(dni);
            string url = "https://localhost:7224/ConsultaCuentasPorDNI";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);



            DataTable dt = (DataTable)JsonConvert.DeserializeObject(result, typeof(DataTable));
            dgvMostrarCliente.DataSource = dt;

            dgvMostrarCliente.AutoSize = true;
            if (dgvMostrarCliente.Rows.Count == 0)
            {
                MessageBox.Show("No existen cuentas asociadas a ese DNI");
            }

        }

        private  void btnNuevaCuenta_Click(object sender, EventArgs e)  
        {
            if (dgvMostrarCliente.RowCount < 1)
            {
                MessageBox.Show("Debe seleccionar el dni del cliente existente al que quiere asociar una nueva cuenta");
                return;
            }
            Cliente miCliente1 = new Cliente();
            int contador = 0;

                foreach (DataGridViewRow item in dgvMostrarCliente.Rows)
                {

                if (item.Cells["Id"].Value.ToString()!= null)
                {
                    miCliente1.idCliente = Convert.ToInt32(item.Cells["Id"].Value.ToString());
                    contador++;
                }
                if (item.Cells["Nombre"].Value.ToString() != null)
                    {
                        miCliente1.nombre = (item.Cells["Nombre"].Value.ToString());
                    contador++;
                    }
                if (item.Cells["Apellido"].Value.ToString() != null)
                {
                    miCliente1.apellido = (item.Cells["Apellido"].Value.ToString());
                    contador++;
                }
                if (item.Cells["DNI"].Value.ToString() != null)
                {
                    miCliente1.dni = Convert.ToInt32(item.Cells["DNI"].Value.ToString());
                    contador++;
                } 



                if (contador==4)
                {
                    break;
                }

            }

            new Form_NuevaCuenta_ClienteExistente(miCliente1).ShowDialog();
            
        }




        private async void btnBajaCuenta_Click(object sender, EventArgs e)   
        {

            double cuentaBaja = Convert.ToDouble(dgvMostrarCliente.CurrentRow.Cells[5].Value.ToString());
            if (MessageBox.Show("seguro que desea dar de baja la cuentaSeleccionada" + cuentaBaja + "?",
              "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                await DeleteCuentaAsync(cuentaBaja);
            }
        }

        private async Task DeleteCuentaAsync( double cuentaBaja)
        {


            string bodyContent = JsonConvert.SerializeObject(cuentaBaja);
            string url = "https://localhost:7224/BajaLogicaCuenta";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Se dio de baja con exito");

            }
            else
            {
                MessageBox.Show("Error!!, NO se pudo dar de baja la cuenta", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }



            /*
                if (factory.DeleteCbu(cuentaBaja))
                {
                    MessageBox.Show("La cuenta " + cuentaBaja + " ha sido dada de baja");
                }
                else
                {
                    MessageBox.Show("ERROR! - La cuenta no ha podido ser dada de baja");
                }
            */


        }


        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            new Form_Movimiento_de_saldos().ShowDialog();
        }

        private void btnVolverMenuAnterior_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_MostrarDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
