
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
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDbanco
{
    public partial class Form_AltaCliente : Form
    {

        private Cliente miCliente;
        private int ProxiD { get; set; }
        private double ProxCbu { get; set; }

        
        public Form_AltaCliente()
        {
            InitializeComponent();

        }

        private void enviarCorreo() // desde la direccion de nico se envia un mail cada vez que se registra un cliente nuevo para dar la Bienvenida
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp-mail.outlook.com");

                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                System.Net.NetworkCredential credential = new System.Net.NetworkCredential("cuentacorreonico@outlook.com", "Nico12345");
                client.EnableSsl = true;
                client.Credentials = credential;

                MailMessage message = new MailMessage("cuentacorreonico@outlook.com", txtMail.Text);
                message.Subject = "Alta de cliente";
                message.Body = "<h1>Alta de cliente Banco Meta</h1>";
                message.IsBodyHtml = true;
                client.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se enviara el mail en unos instantes");
                throw;
            }
        }

        private async void AltaCliente_Load(object sender, EventArgs e)
        {
           await Iniciar();
           
        }

        private async Task Iniciar()
        {
            await ObtenerProximoAsync();
            await CargarCombo();
            await CargarComboEstados();
            await ObtenerProximoCBUAsync();

             miCliente = new Cliente();
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

        private async Task ObtenerProximoAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string url =  "https://localhost:7224/ProximoID";
                var result = await client.GetAsync(url);

                string content = await result.Content.ReadAsStringAsync();

                ProxiD = JsonConvert.DeserializeObject<int>(content); // ver


            }
        }


        private async Task CargarComboEstados()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:7224/ComboEstadoCivil";
                var result = await client.GetAsync(url);
                string content = await result.Content.ReadAsStringAsync();

                var lsta = JsonConvert.DeserializeObject<List<EstadoCivil>>(content);

                cboEstadoCivil.DataSource = lsta;
                cboEstadoCivil.ValueMember = "id_estado";
                cboEstadoCivil.DisplayMember = "nom_estado";
            }

        }

        private async Task CargarCombo()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:7224/tpCuenta";
                var result = await client.GetAsync(url);
                string content = await result.Content.ReadAsStringAsync();

                var lst = JsonConvert.DeserializeObject<List<TipoCuenta>>(content); 

                cboTipoCuenta.DataSource = lst;
                cboTipoCuenta.ValueMember = "id";
                cboTipoCuenta.DisplayMember = "nom_tipo_cta";
            }
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

            await grabarMaestroDetalleAsync();
            
        }

        private async Task grabarMaestroDetalleAsync()
        {
           await ObtenerProximoAsync();

            miCliente.apellido = txtApellido.Text;
            miCliente.nombre = txtNombre.Text;
            miCliente.dni = Convert.ToInt32(txtDni.Text);
            miCliente.idCliente = ProxiD;
            miCliente.mail = txtMail.Text;
            miCliente.estadoCiv.id_estado = Convert.ToInt32(cboEstadoCivil.SelectedValue);
            miCliente.estadoCiv.nom_estado = cboEstadoCivil.Text;



            string bodyContent = JsonConvert.SerializeObject(miCliente);
            string url = "https://localhost:7224/api/Clientes";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);



            if (result.Equals("true"))
            {
                MessageBox.Show("Se inserto con exito", "BIEN", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                MessageBox.Show("Se acaba de enviar unn mail de bienvenida a la direccion : " + txtMail.Text);
                enviarCorreo(); 
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Error!!, NO inserto con exito", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }
            await Iniciar();

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
            txtMail.Text = "";
            cboEstadoCivil.SelectedIndex = -1;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar la ventana y volver al menu anterior?",
              "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                this.Close();
        }
        private  async void btnAgregar_Click(object sender, EventArgs e)
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
            return ;
            }
            foreach (DataGridViewRow item in dgvClientes.Rows)
            {
                if (item.Cells["colTipo"].Value.ToString().Equals(cboTipoCuenta.Text)) //solo 1 cuenta por tipo de cuenta
                {
                    MessageBox.Show("La Cuenta: " + cboTipoCuenta.Text + " Ya esta cargada en la grilla", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                    return;
                }

            }



            TipoCuenta tp = new TipoCuenta();

            tp.nom_tipo_cta = cboTipoCuenta.Text;
            tp.id = Convert.ToInt32(cboTipoCuenta.SelectedValue);
            double saldo = Convert.ToDouble(txtSaldo.Text);
            double cbu = Convert.ToDouble(txtcbu.Text);
            DateTime fecha = Convert.ToDateTime(txtUltimoMov.Text);

            Cuenta cuenta = new Cuenta(cbu, saldo, fecha, tp.id, tp.nom_tipo_cta);
            miCliente.AgregarCuenta(cuenta);

            txtcbu.Text = (Convert.ToDouble(txtcbu.Text)+1).ToString();




            dgvClientes.Rows.Add(cuenta.Cbu, cuenta.Saldo, cuenta.tpCuenta.nom_tipo_cta, cuenta.UltimoMovimiento);

        }

        
            public async Task ActualizarCbu()
        {
            await ObtenerProximoCBUAsync();
            MessageBox.Show("Proximo cbu Actualizado");
        }

        private void btnVolverMenuAnterior_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
