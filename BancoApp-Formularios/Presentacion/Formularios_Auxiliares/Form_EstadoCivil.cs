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

namespace BancoApp_Formularios.Presentacion.Formularios_Auxiliares
{
    public partial class Form_EstadoCivil : Form
    {
       
        private bool nuevo;
        

        public Form_EstadoCivil()
        {
           
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

        private async void btnConsultar_Click(object sender, EventArgs e) 
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

            await VerEstadoAsync(dni);    
        }

        private async Task VerEstadoAsync(int dni)  
        {
            string bodyContent = JsonConvert.SerializeObject(dni);
            string url = "https://localhost:7224/VerEstadoCivil"; 
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result != "")
            {
                lblResultado.Text = "Estado: " + result;

            }
            else
            {
                MessageBox.Show("Error!!, NO se pudo recuperar el Estado Civil registrado anteriormente", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }

        }

        private async void btnModificar_Click(object sender, EventArgs e)   
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

            await ModificarEstadoCivilAsync(dni, nuevoEstado);
        }


        private async Task ModificarEstadoCivilAsync(int dni, int nuevoEsatdoCivil)
        {
            Cliente miCliente = new Cliente();
            miCliente.dni = dni;
            miCliente.estadoCiv.id_estado = nuevoEsatdoCivil;


            string bodyContent = JsonConvert.SerializeObject(miCliente);
            string url = "https://localhost:7224/ModificarEstadoCivil"; // ver
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Se acualizo el Estado Civil con exito");
                lblResultado.Text = "Estado Actualizado";

            }
            else
            {
                MessageBox.Show("Error!!, NO se pudo actualizar el Estado Civil registrado anteriormente", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
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

        private async void verificarnuevoestado(bool nuevo)  
        {
          
            if (txtNuevoEstado.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nuevo estado que no figure en La lista del combo");
                return;
            }
            string nuevoEstado = txtNuevoEstado.Text;
            int  idViejoEstado = (cboEstadoExistente.SelectedIndex +1); 
            if (nuevo)
            {
                await GrabarNuevoEstadoCivilAsync(nuevoEstado);
               
            }  
             else{
                await ModificarNuevoEstadoCivilAsync(nuevoEstado, idViejoEstado);
            
            }
            

        }


        private async Task GrabarNuevoEstadoCivilAsync( string nuevoEstado)
        {
            string bodyContent = JsonConvert.SerializeObject(nuevoEstado);
            string url = "https://localhost:7224/AgregarEstadoCivilEnTabla"; 
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Se Agrego el Estado Civil nuevo en la tabla");


            }
            else
            {
                MessageBox.Show("Error!!, NO se pudo actualizar el Estado Civil", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }

        }

        private async Task ModificarNuevoEstadoCivilAsync(string nuevoEstado,int IdViejoEstado)
        {
           EstadoCivil MiNuevoEstado = new EstadoCivil(IdViejoEstado, nuevoEstado);

            string bodyContent = JsonConvert.SerializeObject(MiNuevoEstado);
            string url = "https://localhost:7224/ModificarEstadoCivilEnTabla"; 
            var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Se Actualizo en la tabla Estado Civil el Estado Civil con suministrado");
               

            }
            else
            {
                MessageBox.Show("Error!!, NO se pudo actualizar el Estado Civil registrado anteriormente", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
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
