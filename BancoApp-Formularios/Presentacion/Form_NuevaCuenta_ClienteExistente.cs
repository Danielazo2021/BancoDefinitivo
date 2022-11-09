using Banco_BibliotecaDDL.Dominio;
using Banco_BibliotecaDDL.Servicios;
using BancoApp_Formularios.HTTP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoApp_Formularios.Presentacion
{
    public partial class Form_NuevaCuenta_ClienteExistente : Form
    {
        private Cliente miCliente;
       // private int ProxiD { get; set; }
        private double ProxCbu { get; set; }

        public Form_NuevaCuenta_ClienteExistente(Cliente miCliente1)
        {

            InitializeComponent();

            this.miCliente = miCliente1;

            txtApellido.Text = miCliente1.apellido;
            txtDni.Text = miCliente1.dni.ToString();
            txtNombre.Text = miCliente1.nombre;
        }

        private async void Form_NuevaCuenta_ClienteExistente_Load(object sender, EventArgs e)
        {
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtDni.Enabled = false;
           await CargarCombo();
            await ObtenerProximoCBUAsync();

        }




        private async Task CargarCombo()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:7224/tpCuenta";
                var result = await client.GetAsync(url);
                string content = await result.Content.ReadAsStringAsync();

                var lst1 = JsonConvert.DeserializeObject<List<TipoCuenta>>(content);

                cboTipoCuenta.DataSource = lst1;
                cboTipoCuenta.ValueMember = "id";
                cboTipoCuenta.DisplayMember = "nom_tipo_cta";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtSaldo.Text == "")
            {
                MessageBox.Show("Cargar un Saldo", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                return;
            }
            if (txtUltimoMov.Text == "")
            {
                MessageBox.Show("Cargue el ultimo movimiento", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                return;
            }
            if (txtcbu.Text == "")
            {
                MessageBox.Show("Cargar el cbu", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                return;
            }
            if(dgvClientes.Rows.Count>0)
            {
                MessageBox.Show("Solo puede agregar de a una las cuentas extra a clientes ya registrados","ATENCION!!", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                return;
            }
            /*foreach (DataGridViewRow item in dgvClientes.Rows)
            {
                if (item.Cells["colTipo"].Value.ToString().Equals(cboTipoCuenta.Text)) //solo 1 cuenta por tipo de cuenta
                {
                    MessageBox.Show("La Cuenta: " + cboTipoCuenta.Text + " Ya esta cargada en la grilla", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                    return;
                }

            }*/

            TipoCuenta tp = new TipoCuenta();
            tp.nom_tipo_cta = cboTipoCuenta.Text;
            tp.id = Convert.ToInt32(cboTipoCuenta.SelectedValue);
            double saldo = Convert.ToDouble(txtSaldo.Text);
            double cbu = Convert.ToDouble(txtcbu.Text);
            DateTime fecha = Convert.ToDateTime(txtUltimoMov.Text);

            Cuenta cuenta = new Cuenta(cbu, saldo, fecha, tp.id, tp.nom_tipo_cta);
            miCliente.AgregarCuenta(cuenta);

            dgvClientes.Rows.Add(cuenta.Cbu, cuenta.Saldo, cuenta.tpCuenta.nom_tipo_cta, cuenta.UltimoMovimiento);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar la ventana y volver al menu anterior?",
            "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                this.Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Cargar el Apellido", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Cargar el cbu", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }

            if (txtDni.Text == "")
            {
                MessageBox.Show("Cargar el cbu", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }

            await grabarDetalleAsync();
            await ObtenerProximoCBUAsync();
            this.Dispose();

        }
        private async Task grabarDetalleAsync()
        {
            string bodyContent = JsonConvert.SerializeObject(miCliente);
            string url = "https://localhost:7224/AgregaCuentaSola";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Se inserto con exito", "BIEN", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error!!, NO inserto con exito", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }
        }

        private void limpiarCampos()
        {
            txtApellido.Text = "";
            txtcbu.Text = "";
            txtDni.Text = "";
            cboTipoCuenta.SelectedIndex = -1;
            txtNombre.Text = "";
            txtSaldo.Text = "";
            txtUltimoMov.Text = "";
            dgvClientes.Rows.Clear();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentCell.ColumnIndex == 4)
            {
                miCliente.EliminarCuenta(dgvClientes.CurrentRow.Index);
                dgvClientes.Rows.Remove(dgvClientes.CurrentRow);
            }
        }

        private async Task ObtenerProximoCBUAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:7224/ProximoCBU";
                var result = await client.GetAsync(url);
                string content = await result.Content.ReadAsStringAsync();

                ProxCbu = JsonConvert.DeserializeObject<double>(content);
            }
            txtcbu.Text = (ProxCbu).ToString();
            txtcbu.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
