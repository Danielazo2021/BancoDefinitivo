using Banco_BibliotecaDDL.DataAccess;

using Banco_BibliotecaDDL.Dominio;
using System.Data;
using System.Net;


namespace Banco_BibliotecaDDL.Servicios
{
    public class Servicio : IServicio
    {
        private IDaoCliente dao;

        public Servicio()
        {
            dao = new DaoCliente();
        }

        public List<TipoCuenta> ObtenerCuentas()
        {
            return dao.ObtenerCuentas();
        }

        public double ObtenerProximo()
        {
            return dao.ObtenerProximo();
        }

        public bool DeleteDni(int dni)
        {
            return dao.DeleteDni(dni);
        }
        public bool DeleteCbu(double cbu)
        {
            return dao.DeleteCbu(cbu);
        }






        // del controller los traje
        public bool validarLogin(usuarioLogin miUsuario)
        {
            return dao.validarLogin(miUsuario);
        }
        public bool RegistrarLogin(usuarioLogin miUsuario)
        {
            return dao.RegistrarLogin(miUsuario);
        }
        public bool ActualizarLogin(usuarioLogin login)
        {
            return dao.ActualizarLogin(login);
        }

        public bool DeleteLogin(int dni)
        {
            return dao.DeleteLogin(dni);
        }
        public bool ValidarSeguridadPass(string pass)
        {
            return dao.ValidarSeguridadPass(pass);
        }
        public bool ConsultarExistencia(int dni)
        {
            return dao.ConsultarExistencia(dni);
        }



        // controller Clientes
        public DataTable ListarClientes()
        {
            return dao.ListarClientes();
        }


        public DataTable ListarClientes(int dni)
        {
            return dao.ListarClientes(dni);
        }


        public bool GrabaMaestroDetalle(Cliente oCliente)
        {
            return dao.GrabaMaestroDetalle(oCliente);
        }

        public DataTable ConsultarCuentasPorDNI(int dni)
        {
            return dao.ConsultarCuentasPorDNI(dni);
        }

        public bool AgregarDetalleaClienteExistente(Cliente miCliente)
        {

            return dao.AgregarDetalleaClienteExistente(miCliente);
        }

        public DataTable ObtenerEstadoCivil()
        {
            return dao.ObtenerEstadoCivil();
        }



        public bool TransferirEntreMisCuentas(List<Cuenta> transfer)
        {
            return dao.TransferirEntreMisCuentas(transfer);
        }

        public string VerEstadoCivil(int dni)
        {
            return dao.VerEstadoCivil(dni);
        }


        public bool ModificarEstadoCivil(int dni, int nuevoEstadoCivil) // es el id estado en realidad
        {
            return dao.ModificarEstadoCivil(dni, nuevoEstadoCivil);
        }



        public string VerMail(int dni)
        {
            return dao.VerMail(dni);
        }
        public bool ModificarMail(int dni, string nuevoMail)
        {
            return dao.ModificarMail(dni, nuevoMail);
        }

        /* public List<TipoCuenta>? ObtenerEstadoCivil() // modificar
         {
             throw new NotImplementedException();
         }

         public DataTable ReporteClientes()
         {
             throw new NotImplementedException();
         }*/

        public double ObtenerProximoCbu()
        {
            return dao.ObtenerProximoCBU();
        }
    }
}
