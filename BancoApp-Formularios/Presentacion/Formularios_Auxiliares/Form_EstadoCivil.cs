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

        public Form_EstadoCivil()
        {
            factory = new Servicio();
            InitializeComponent();
        }

        private async void Form_EstadoCivil_Load(object sender, EventArgs e)
        {
            await cargarComboEstado();
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
            }
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


            lblResultado.Text = "Estado: " + factory.VerEstadoCivil(dni);


        }

        private void btnModificar_Click(object sender, EventArgs e)
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
            bool resultado = factory.ModificarEstadoCivil(dni, nuevoEstado);
            if (resultado)
            {
                MessageBox.Show("Se actualizo con EXITO el estado Civil!!!");
                lblResultado.Text = "Estado Actualizado";
            }
            else
            {
                MessageBox.Show("ERROR!!, NO se actualizo el Estado Civil");
            }
            // tirar el sp para modificar en la tabla Clientes el estadocivil
            // en base al cbo selecionado



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
    }
}
