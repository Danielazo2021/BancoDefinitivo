
using Banco_BibliotecaDDL.Dominio;
using System.Data;
using System.Net;

namespace Banco_BibliotecaDDL.Servicios
{
    public interface IServicio
    {
        public double ObtenerProximo();

        List<TipoCuenta> ObtenerCuentas();

        public bool DeleteDni(int dni);
        public bool DeleteCbu(double cbu);





        // estos son del controller de usuario Login
        public bool validarLogin(usuarioLogin miUsuario);

        public bool RegistrarLogin(usuarioLogin miUsuario);

        public bool ActualizarLogin(usuarioLogin login);


        public bool DeleteLogin(int dni);

        public bool ValidarSeguridadPass(string pass);

        public bool ConsultarExistencia(int dni);


        // controller Clientes
        public DataTable ListarClientes();
        public DataTable ListarClientes(int dni);

        // crud cliente y cuentas
        public bool GrabaMaestroDetalle(Cliente oCliente);
        public DataTable ConsultarCuentasPorDNI(int dni);

        // Controller Cuentas

        public bool AgregarDetalleaClienteExistente(Cliente miCliente);
        public DataTable ObtenerEstadoCivil();//  
        public bool TransferirEntreMisCuentas(List<Cuenta> transfer);





        public string VerEstadoCivil(int dni); // consulto el estado civil de un cliente en particular por dni
        public bool ModificarEstadoCivil(int dni, int nuevoEstadoCivil);// actualizar estadocivil 
        public string VerMail(int dni);// consulto el Mail de un cliente
        public bool ModificarMail(int dni, string nuevoMail);// actualizar elmail 
       public double ObtenerProximoCbu();


       public bool GrabarNuevoEstadoCivil(string nuevoEstado);
       
        public bool ModificarNuevoEstadoCivil(EstadoCivil miNuevoEstadoCivil);
    }
}
