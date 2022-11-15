
using Banco_BibliotecaDDL.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Data;
using System.Net;

namespace Banco_BibliotecaDDL.DataAccess
{
    public class DaoCliente : IDaoCliente
    {


        public List<TipoCuenta> ObtenerCuentas()
        {
            List<TipoCuenta> lst = new List<TipoCuenta>();
            string sp_nombre = "pa_Cargar_Combo";

            DataTable td = HelperDao.ObtenerInstancia().CargarCombo(sp_nombre);

            foreach (DataRow dr in td.Rows)
            {
                int id = Convert.ToInt32(dr["id_tipo"].ToString());
                string nombre = dr["nom_cuenta"].ToString();

                TipoCuenta aux = new TipoCuenta(id, nombre);
                lst.Add(aux);
            }
            return lst;
        }

        public double ObtenerProximo()
        {

            string sp_nombre = "pa_Proximo_Cliente";
            return HelperDao.ObtenerInstancia().ObtenerProximo(sp_nombre);
        }

        public bool DeleteDni(int dni)
        {
            string sp_nombre = "pa_Baja_Cliente"; //generar baja logica del dni     aunque no se si deberia       
            return HelperDao.ObtenerInstancia().BajaCliente(sp_nombre, dni);
        }

        public bool DeleteCbu(double cbu)
        {
            string sp_nombre = "pa_Baja_Cbu"; //generar baja logica del cbu           
            return HelperDao.ObtenerInstancia().DeleteCbu(sp_nombre, cbu);
        }


        // apartir dde aca controller de login con sus sp


        public bool RegistrarLogin(usuarioLogin miUsuario)
        {
            string sp_nombre = "sp_crear_login";  /// ver si es save usuario o registrar
            return HelperDao.ObtenerInstancia().RegistrarLogin(sp_nombre, miUsuario);
        }



        public bool validarLogin(usuarioLogin miUsuario)
        {
            string sp_nombre = "sp_validar_login"; // ver que paso
            return HelperDao.ObtenerInstancia().ValidarLogin(sp_nombre, miUsuario);
        }
        public bool ActualizarLogin(usuarioLogin miUsuario)
        {
            string sp_nombre = "sp_actualizar_login";
            return HelperDao.ObtenerInstancia().ActualizarLogin(sp_nombre, miUsuario);
        }

        public bool DeleteLogin(int dni)
        {
            string sp_nombre = "sp_borrar_login";
            return HelperDao.ObtenerInstancia().DeleteLogin(sp_nombre, dni);
        }

        public bool ValidarSeguridadPass(string pass)
        {

            return HelperDao.ObtenerInstancia().ValidarSeguridadPass(pass);
        }

        public bool ConsultarExistencia(int dni)
        {
            string sp_nombre = "sp_validar_dni";
            return HelperDao.ObtenerInstancia().ConsultarExistencia(sp_nombre, dni);
        }


        // controller clientes
        public DataTable ListarClientes()
        {
            string sp_nombre = "sp_consultar_todos_los_clientes";
            return HelperDao.ObtenerInstancia().ListarClientes(sp_nombre);
        }

        public DataTable ListarClientes(int dni)
        {
            string sp_nombre = "sp_consultar_cliente_por_DNI";
            return HelperDao.ObtenerInstancia().ListarClientes(sp_nombre, dni);
        }

        /// faltaria hacer el crud de cliente y de cuentas

        public bool GrabaMaestroDetalle(Cliente oCliente)
        {
            string sp_maestro = "pa_Insertar_Cliente_Maestro";
            string sp_detalle = "pa_Insertar_Cuenta_Detalle";
            return HelperDao.ObtenerInstancia().GrabaMaestroDetalle(oCliente, sp_maestro, sp_detalle);

        }

        public DataTable ConsultarCuentasPorDNI(int dni)
        {
            string sp_nombre = "pa_Consultar_Cuentas_Por_DNI";
            return HelperDao.ObtenerInstancia().ConsultarCuentasPorDNI(dni, sp_nombre);

        }


        // controller cuentas
        public bool AgregarDetalleaClienteExistente(Cliente miCliente)
        {
            string sp_nombre = "pa_Insertar_Cuenta_Detalle";
            return HelperDao.ObtenerInstancia().AgregarDetalleaClienteExistente(miCliente, sp_nombre);

        }

        public DataTable ObtenerEstadoCivil() // para el combo estados
        {
            string sp_nombre = "pa_Cargar_ComboEstados";
            return HelperDao.ObtenerInstancia().ObtenerEstadoCivil(sp_nombre);

        }

        public bool TransferirEntreMisCuentas(List<Cuenta> transfer)
        {
            string sp_nombre = "sp_transferencia_cuentas";
            return HelperDao.ObtenerInstancia().TransferirEntreMisCuentas(transfer, sp_nombre);
        }

        public string VerEstadoCivil(int dni)
        {
            string sp_nombre = "sp_verEstadoCivilporDNI";
            return HelperDao.ObtenerInstancia().VerEstadoCivil(dni, sp_nombre);
        }

        public bool ModificarEstadoCivil(int dni, int nuevoEstadoCivil)
        {
            string sp_nombre = "sp_ModificarEstadoCivilporDNI";
            return HelperDao.ObtenerInstancia().ModificarEstadoCivil(dni, sp_nombre, nuevoEstadoCivil);
        }





        public string VerMail(int dni)
        {
            string sp_nombre = "sp_verMailporDNI";
            return HelperDao.ObtenerInstancia().VerMail(dni, sp_nombre);
        }
        public bool ModificarMail(int dni, string nuevoMail)
        {
            string sp_nombre = "sp_ModificarMailporDNI";
            return HelperDao.ObtenerInstancia().ModificarMail(dni, sp_nombre, nuevoMail);
        }

        public DataTable ReporteClientes()  // estaba en uso creo
        {
            throw new NotImplementedException();
        }
        public double ObtenerProximoCBU()
        {
            string sp_nombre = "pa_Proximo_CBU";
            return HelperDao.ObtenerInstancia().ObtenerProximo(sp_nombre);
        }

        public bool GrabarNuevoEstadoCivil(string nuevoEstado)
        {
            string sp_nombre = "pa_altaNuevoEstadoCivil";
            return HelperDao.ObtenerInstancia().GrabarNuevoEstadoCivil(sp_nombre, nuevoEstado);
        }
        
        public bool ModificarNuevoEstadoCivil(EstadoCivil miNuevoEstadoCivil)
        {
            string sp_nombre = "pa_ModificacionNuevoEstadoCivil";
            return HelperDao.ObtenerInstancia().ModificarNuevoEstadoCivil(sp_nombre,  miNuevoEstadoCivil);
        }


    }
    
}
