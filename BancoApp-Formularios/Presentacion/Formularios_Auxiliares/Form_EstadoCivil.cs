using Banco_BibliotecaDDL.Dominio;
using Banco_BibliotecaDDL.Servicios;
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

namespace BancoApp_Formularios.Presentacion.Formularios_Auxiliares
{
    public partial class Form_EstadoCivil : Form
    {
        private IServicio factory;
        private bool nuevo;

        public Form_EstadoCivil()
        {
            factory = new Servicio();
            InitializeComponent();
        
        }

        private async void Form_EstadoCivil_Load(object sender, EventArgs e)
        {
            await cargarComboEstado();

            gbNuevoEstado.Enabled = false;
            btnAgregarNuevoEstado.Enabled = true;
        }


        private async Task cargarComboEstado()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:7224/ComboEstadoCivil";
                var result = await client.GetAsync(url);
                string content = await result.Content.ReadAsStringAsync();

                var lst = JsonConvert.DeserializeObject<List<EstadoCivil>>(content);

                cboEstadoCivil.DataSource = lst;
                cboEstadoCivil.ValueMember = "id_estado";
                cboEstadoCivil.DisplayMember = "nom_estado";


                cboEstadoExistente.DataSource = lst;
                cboEstadoExistente.ValueMember = "id_estado";
                cboEstadoExistente.DisplayMember = "nom_estado";

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e) // cambiar
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


            lblResultado.Text = "Estado: " + factory.VerEstadoCivil(dni);  // este


        }

        private void btnModificar_Click(object sender, EventArgs e)  // cambiar 
        {
            int nuevoEstado = (Convert.ToInt32(cboEstadoCivil.SelectedIndex) + 1);
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

            if (cboEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el nuevo estado civil");
                return;
            }
            bool resultado = factory.ModificarEstadoCivil(dni, nuevoEstado);  // este
            if (resultado)
            {
                MessageBox.Show("Se actualizo con EXITO el estado Civil!!!");
                lblResultado.Text = "Estado Actualizado";
            }
            else
            {
                MessageBox.Show("ERROR!!, NO se actualizo el Estado Civil");
            }
          



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
            cboEstadoCivil.SelectedIndex = -1;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAgregarNuevoEstado_Click(object sender, EventArgs e)
        {
            gbNuevoEstado.Enabled = true;
            gbEstadoExistente.Enabled = false;
            
            

        }

        private void verificarnuevoestado(bool nuevo)  // cambiar 
        {
          
            if (txtNuevoEstado.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nuevo estado que no figure en La lista del combo");
                return;
            }
            string nuevoEstado = txtNuevoEstado.Text;
            string viejoEstado = cboEstadoExistente.Text;
            if (nuevo)
            {
                factory.GrabarNuevoEstadoCivil(nuevoEstado);  // este 
            }  
             else{
                factory.ModificarNuevoEstadoCivil(nuevoEstado, viejoEstado);  // este
            }
            

        }


        private async void btnGrabarNuevoEstado_Click(object sender, EventArgs e)
        {
            nuevo = true;
            verificarnuevoestado(nuevo);

            gbEstadoExistente.Enabled = true;
            gbNuevoEstado.Enabled = false;


            await cargarComboEstado();
        }

        private async void btnModificarEstadoExistente_Click(object sender, EventArgs e)
        {
            nuevo = false;


            verificarnuevoestado(nuevo);

            gbEstadoExistente.Enabled = true;
            gbNuevoEstado.Enabled = false;

            await cargarComboEstado();
        }

    
    }
}
