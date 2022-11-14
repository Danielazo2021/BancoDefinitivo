using BancoApp_Formularios.Presentacion.Formularios_Auxiliares;
using CRUDbanco;
using CRUDbanco.Presentacion;

namespace BancoApp_Formularios.Presentacion
{
    public partial class Form_MenuPrincipal : Form
    {
        public Form_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
            "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                this.Close();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_AltaCliente().Show();
        }

        private void consultaClientesMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_MostrarDatos().Show(); 
        }

        

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_MostrarDatos().ShowDialog();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_MostrarDatos().ShowDialog(); 
        }

        private void modificacionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void altaClienteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_AltaCliente().ShowDialog(); 
        }

        private void movimientoDeSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Form_Movimiento_de_saldos().ShowDialog();

            
        }

        
        private void datosDeContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_MailDeContacto().ShowDialog();
        }

        private void tablaDeEstadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_EstadoCivil().ShowDialog();
        }

        private void equipoDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_EquipoDeTrabajo().ShowDialog(); 
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Banco_Reportes.FORMULARIOS.FormReporteCuentas().Show();
        }

        private void reporteConFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Banco_Reportes.FORMULARIOS.FormReporteCuentasBaja().Show();
            
        }
    }
}
