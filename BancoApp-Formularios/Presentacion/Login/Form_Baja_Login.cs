using Banco_BibliotecaDDL.Servicios;
using Banco_BibliotecaDDL.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoApp_Formularios.Presentacion.Login
{
    public partial class Form_Baja_Login : Form
    {
        private IServicio factory = new Servicio();
        usuarioLogin miUsuario = new usuarioLogin();
        public Form_Baja_Login()
        {
            InitializeComponent();
        }

        private void Form_Baja_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI que quiere dar de Baja");
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Debe ingresar la contraseña del usuario que quiere dar de Baja");
                return;
            }

            miUsuario.dni = Convert.ToInt32(txtDni.Text);
            miUsuario.pass = txtPass.Text;
            bool confirmacion = factory.validarLogin(miUsuario);
           

            if (confirmacion)
            {
                factory.DeleteLogin(Convert.ToInt32(txtDni.Text));
                MessageBox.Show("el usuario eliminado");
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Usuario inexistente");
                limpiarCampos();

            }

        }

        private void limpiarCampos()
        {
            txtDni.Text = "";            
            txtPass.Text = "";
        }

        private void btnVolverMenuAnterior_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
