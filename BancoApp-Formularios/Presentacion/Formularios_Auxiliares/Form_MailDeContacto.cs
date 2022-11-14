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
using System.Net;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoApp_Formularios.Presentacion.Formularios_Auxiliares
{
    public partial class Form_MailDeContacto : Form
    {
        private IServicio factory;
        public Form_MailDeContacto()
        {
            factory = new Servicio();
            InitializeComponent();
        }
        private async void btnConsultar_Click(object sender, EventArgs e) //cambiar
        {
            int dni;
            try
            {
                dni = Convert.ToInt32(txtDni.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un dni Valido");
                return;
            }

             await VerMailAsync(dni);// factory.VerMail(dni);  // este
        }

        private async Task VerMailAsync(int dni)  //   ok
        {
            string bodyContent = JsonConvert.SerializeObject(dni);
            string url = "https://localhost:7224/VerMail";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);
                                 
            if (result !="") 
            {
                lblResultado.Text = "Mail:  " + result;
                
            }
            else
            {
                MessageBox.Show("Error!!, NO se pudo recuperar el email registrado anteriormente", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }  

        }

        private async void btnModificarMail_Click(object sender, EventArgs e)  // cambiar
        {

            string nuevoMail = txtMail.Text;
            int dni;
            try
            {
                dni = Convert.ToInt32(txtDni.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un dni Valido");
                return;
            }

            if (txtMail.Text == "")
            {
                MessageBox.Show("Debe ingresar el nuevo mail");
                return;
            }

             await ModificarMailAsync(dni, nuevoMail);
            
        }

        private async Task ModificarMailAsync(int dni, string nuevoMail)
        {
            Cliente miCliente = new Cliente();
            miCliente.dni = dni;
            miCliente.mail = nuevoMail;


            string bodyContent = JsonConvert.SerializeObject(miCliente);
            string url = "https://localhost:7224/ModificarMail";
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Se acualizo el mail con exito");

            }
            else
            {
                MessageBox.Show("Error!!, NO se pudo actualizar el email registrado anteriormente", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }


        }


        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtDni.Text = "";
            txtDni.Focus();
            lblResultado.Text = "Resultado de la busqueda: ";
            txtMail.Text = "";


        }

        private void Form_MailDeContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
