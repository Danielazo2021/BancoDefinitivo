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
        IServicio factory;
        int dni;

        public Form_MostrarDatos()
        {
            InitializeComponent();
            factory = new Servicio();
        }


        private async void btnConsultar_Click_1(object sender, EventArgs e)  //deberia ser async
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

        private void btnNuevaCuenta_Click(object sender, EventArgs e)
        {
            if (dgvMostrarCliente.RowCount < 1)
            {
                MessageBox.Show("Debe seleccionar el dni del cliente existente al que quiere asociar una nueva cuenta");
                return;
            }
            Cliente miCliente1 = new Cliente();


            DataTable clientes;

            try
            {
                clientes = factory.ListarClientes(dni);

                for (int i = 0; i < (clientes.Rows.Count); i++)
                {

                    miCliente1.idCliente = Convert.ToInt32(clientes.Rows[i]["id_cliente"]);
                    miCliente1.nombre = clientes.Rows[i]["nom_cliente"].ToString();
                    miCliente1.apellido = clientes.Rows[i]["ape_cliente"].ToString();
                    miCliente1.dni = Convert.ToInt32(clientes.Rows[i]["dni"]);
                }

                new Form_NuevaCuenta_ClienteExistente(miCliente1).ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }



        private void btnBajaCuenta_Click(object sender, EventArgs e)
        {

            double cuentaBaja = Convert.ToDouble(dgvMostrarCliente.CurrentRow.Cells[5].Value.ToString());
            if (MessageBox.Show("seguro que desea dar de baja la cuentaSeleccionada" + cuentaBaja + "?",
              "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (factory.DeleteCbu(cuentaBaja))
                {
                    MessageBox.Show("La cuenta " + cuentaBaja + " ha sido dada de baja");
                }
                else
                {
                    MessageBox.Show("ERROR! - La cuenta no ha podido ser dada de baja");
                }

            }

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
