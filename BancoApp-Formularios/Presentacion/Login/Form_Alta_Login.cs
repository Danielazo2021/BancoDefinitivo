using Banco_BibliotecaDDL.Servicios;
using bacnoApp_winForm;
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
    public partial class Form_Alta_Login : Form
    {
        private IServicio factory = new Servicio();
        usuarioLogin miUsuario = new usuarioLogin();

        public Form_Alta_Login()
        {
            InitializeComponent();
        }

        private void Form_Alta_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI");
                return;
            }
            if (txtNomUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario");
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Debe ingresar la contraseña");
                return;
            }

            if (!factory.ValidarSeguridadPass(txtPass.Text))
            {
                MessageBox.Show("Contraseña no aceptada, la contraseña debe contener al menos 1 mayuscula, 1 minuscula, 1 caracter especial y 1 numero con una extencion total de 10 caracteres!!");
                return;
            }
            if(factory.ConsultarExistencia(Convert.ToInt32(txtDni.Text)))
            {
                MessageBox.Show("El Dni ya se encurntra registrado");
                 return;
            }

            miUsuario.dni = Convert.ToInt32(txtDni.Text);
            miUsuario.nom_usuario = txtNomUsuario.Text;
            miUsuario.pass = txtPass.Text;

            try
            {
                factory.RegistrarLogin(miUsuario);
                MessageBox.Show("Usuario registrado con exito!!");
            }
            catch
            {
                MessageBox.Show("Error al registrar usuario");
            }

            finally
            {
                this.Dispose();
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se ha generado el usuario miCliente");
            this.Dispose();
        }

        private void btnVolverMenuAnterior_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }
    }
}
