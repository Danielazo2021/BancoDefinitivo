
using Banco_BibliotecaDDL.Dominio;
using System.Data;

namespace Banco_BibliotecaDDL.DataAccess
{
    public interface IDaoCliente
    {
        public double ObtenerProximo();

        List<TipoCuenta> ObtenerCuentas();


        public bool DeleteDni(int dni);
        public bool DeleteCbu(double cbu);


        // controller de login
        public bool validarLogin(usuarioLogin miUsuario);
        public bool RegistrarLogin(usuarioLogin miUsuario);
        public bool ActualizarLogin(usuarioLogin login);
        public bool DeleteLogin(int dni);
        public bool ValidarSeguridadPass(string pass);
        public bool ConsultarExistencia(int dni);


        //controller de clientes del banco
        public DataTable ListarClientes();
        public DataTable ListarClientes(int dni);

        /// faltaria hacer el crud de cliente y de cuentas
        public bool GrabaMaestroDetalle(Cliente oCliente);

        public DataTable ConsultarCuentasPorDNI(int dni);

        // controller de cuenta
        public bool AgregarDetalleaClienteExistente(Cliente miCliente);
        public DataTable ObtenerEstadoCivil();

        public bool TransferirEntreMisCuentas(List<Cuenta> transfer);

        public string VerEstadoCivil(int dni);
        public bool ModificarEstadoCivil(int dni, int nuevoEstadocivil);


        public string VerMail(int dni);

        public bool ModificarMail(int dni, string nuevoMail);
    
        public DataTable ReporteClientes(); // ver que onda

        public double ObtenerProximoCBU();

        public bool GrabarNuevoEstadoCivil(string nuevoEstado);
        
        public bool ModificarNuevoEstadoCivil(EstadoCivil miNuevoEstadoCivil);
    }
}
