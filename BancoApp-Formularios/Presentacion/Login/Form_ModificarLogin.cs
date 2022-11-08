using bacnoApp_winForm;

namespace BancoApp_Formularios.Presentacion.Login
{
    public partial class Form_ModificarLogin : Form
    {
        public Form_ModificarLogin()
        {
            InitializeComponent();
        }

        private void Form_ModificarLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverMenuAnterior_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            this.Dispose();
        }

        private void limpiarCampos()
        {
            txtDni.Text = "";
            txtNomUsuario.Text = "";
            txtPass.Text = "";
        }
    }
}
