using Banco_BibliotecaDDL.Servicios;
using Banco_BibliotecaDDL.Dominio;
using BancoApp_Formularios.HTTP;
using BancoApp_Formularios.Presentacion;
using BancoApp_Formularios.Presentacion.Login;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace bacnoApp_winForm
{
    public partial class Form_Inicio_de_Sesion : Form
    {
       private IServicio factory= new Servicio();
        usuarioLogin miUsuario { get; set; } = new usuarioLogin();
      

        public Form_Inicio_de_Sesion()
        {
            InitializeComponent();
        }

        private  async void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtDni.Text=="")
            {
                MessageBox.Show("Debe ingresar un DNI");
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Debe ingresar la contraseña");
                return;
            }


            await VerificarLoginAsync();//miUsuario);

           
        }

        private  async Task VerificarLoginAsync()//usuarioLogin miUsuario)
        {
            miUsuario.dni = Convert.ToInt32(txtDni.Text);
            miUsuario.pass = txtPass.Text;
           


             bool confirmacion= factory.validarLogin(miUsuario); 

           

            if (confirmacion) 
            {

                limpiarCampos();
                new Form_MenuPrincipal().ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta, intente nuevamente para continuar");
                limpiarCampos();
            }
            

        }


        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            new Form_Alta_Login().ShowDialog();          
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI");
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Debe ingresar la contraseña");
                return;
            }
            miUsuario.dni = Convert.ToInt32(txtDni.Text);
            miUsuario.pass = txtPass.Text;
            bool confirmacion = factory.validarLogin(miUsuario); 
            

            if (confirmacion)
            {
                limpiarCampos();
                new Form_ModificarLogin().ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta, intente nuevamente para continuar");
                limpiarCampos();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI");
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Debe ingresar la contraseña");
                return;
            }
            miUsuario.dni = Convert.ToInt32(txtDni.Text);
            miUsuario.pass = txtPass.Text;

            bool confirmacion = factory.validarLogin(miUsuario);

           

            if (confirmacion)
            {
                limpiarCampos();
                new Form_Baja_Login().ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta, intente nuevamente para continuar");
                limpiarCampos();

            }
            
        }
      

        private void Form_Inicio_de_Sesion_Load(object sender, EventArgs e)
        {
            btnCambiarPass.Enabled = false;
            btnEliminarUsuario.Enabled = false;
            txtPass.PasswordChar = '*'; 
        }
        private void limpiarCampos()
        {
            txtDni.Text = "";
            txtPass.Text = "";
        }

        private void btnMostrarPass_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
}
