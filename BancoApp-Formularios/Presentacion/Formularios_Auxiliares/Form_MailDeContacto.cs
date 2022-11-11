using Banco_BibliotecaDDL.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private void btnConsultar_Click(object sender, EventArgs e)
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

            lblResultado.Text = "Mail:  " + factory.VerMail(dni);
        }

        private void btnModificarMail_Click(object sender, EventArgs e)
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
            bool resultado = factory.ModificarMail(dni, nuevoMail);
            if (resultado)
            {
                MessageBox.Show("Se actualizo con EXITO el mail!!!");
                lblResultado.Text = "Mail Actualizado a:  " + txtMail.Text;
            }
            else
            {
                MessageBox.Show("ERROR!!, NO se actualizo el mail");
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

        
    }
}
