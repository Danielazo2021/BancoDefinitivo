
using Banco_BibliotecaDDL.Dominio;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;

namespace Banco_BibliotecaDDL.DataAccess
{
    public class HelperDao
    {
        private static HelperDao instancia;
        SqlConnection cnn = new SqlConnection(Banco_BibliotecaDDL.Properties.Resources.cnnCRUDbanco); // ver si con el biblioteca que le puse anda la instancia

        public double Origen;
        public double Destino;
        public double Importe;

        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDao();
            return instancia;
        }

        public double ObtenerProximo(string sp_nombre)
        {
            SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
            DataTable tabla = new DataTable();
            double verificacion = 0;
            try
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@next";
                pOut.DbType = DbType.Double; // Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                cnn.Close();
                try
                {
                    verificacion = (double)pOut.Value;

                }
                catch
                {
                    return 0;
                }

                return ((double)pOut.Value + 1);

            }
            catch (SqlException ex)
            {
                return 1;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

        }
        /*public int ObtenerProximoCBU(string sp_nombre)
        {
            SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
            DataTable tabla = new DataTable();
            int verificacion = 0;
            try
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@next";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                cnn.Close();
                try
                {
                    verificacion = (int)pOut.Value;

                }
                catch
                {
                    return 0;
                }

                return ((int)pOut.Value + 1);

            }
            catch (SqlException ex)
            {
                return 1;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

        }*/

        public DataTable CargarCombo(string sp_nombre)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmdCombo = new SqlCommand();
            cmdCombo.Connection = cnn;
            cmdCombo.CommandText = sp_nombre;
            cmdCombo.CommandType = CommandType.StoredProcedure;

            dt.Load(cmdCombo.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public bool GrabaMaestroDetalle(Cliente oCliente, string sp_maestro, string sp_detalle) // graba maestro y detalle
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                SqlCommand cmdMaestro = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();

                cmdMaestro.Connection = cnn;
                cmdMaestro.Transaction = t;
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.CommandText = sp_maestro;

                cmdMaestro.Parameters.AddWithValue("@apellido", oCliente.apellido);
                cmdMaestro.Parameters.AddWithValue("@nombre", oCliente.nombre);
                cmdMaestro.Parameters.AddWithValue("@dni", oCliente.dni);
                cmdMaestro.Parameters.AddWithValue("@id_cliente", oCliente.idCliente);
                cmdMaestro.Parameters.AddWithValue("@mail", oCliente.mail);
                cmdMaestro.Parameters.AddWithValue("@id_estado", oCliente.estadoCiv.id_estado);

                cmdMaestro.ExecuteNonQuery();
                int cod_Cliente = oCliente.idCliente;

                foreach (Cuenta item in oCliente.Cuentas)
                {
                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.CommandText = sp_detalle;
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Transaction = t;

                    cmdDetalle.Parameters.AddWithValue("@cbu", item.Cbu);
                    cmdDetalle.Parameters.AddWithValue("@id_tipo", item.tpCuenta.id);
                    cmdDetalle.Parameters.AddWithValue("@saldo", item.Saldo);
                    cmdDetalle.Parameters.AddWithValue("@ultimoMov", item.UltimoMovimiento);
                    cmdDetalle.Parameters.AddWithValue("@id_cliente", cod_Cliente);

                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                return ok = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }

        public bool BajaCliente(string sp_nombre, int dni) // generar el sp de nombre "pa_Baja_Cliente"
        {
            bool confirmacion = false;

            try
            {
                SqlCommand cmdMaestro = new SqlCommand();
                cnn.Open();
                cmdMaestro.Connection = cnn;
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.CommandText = sp_nombre;
                cmdMaestro.Parameters.AddWithValue("@dni", dni);

                cmdMaestro.ExecuteNonQuery();
                confirmacion = true;

            }
            catch (Exception)
            {

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return confirmacion;
        }

        public bool DeleteCbu(string sp_nombre, double cbu) // generar el sp de nombre "pa_Baja_Cbu"
        {
            bool confirmacion = false;

            try
            {
                SqlCommand cmdMaestro = new SqlCommand();
                cnn.Open();
                cmdMaestro.Connection = cnn;
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.CommandText = sp_nombre;
                cmdMaestro.Parameters.AddWithValue("@cbu", cbu);

                cmdMaestro.ExecuteNonQuery();
                confirmacion = true;

            }
            catch (Exception)
            {

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return confirmacion;
        }

        // controller login falta atticular chanta

        public bool RegistrarLogin(string sp_nombre, usuarioLogin login)
        {
            bool status = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", login.dni);
                cmd.Parameters.AddWithValue("@nom_usuario", login.nom_usuario);
                cmd.Parameters.AddWithValue("@pass", login.pass);

                cmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return status;
        }

        public bool ValidarLogin(string sp_nombre, usuarioLogin login)
        {
            bool status = false;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable tabla = new DataTable();

                cmd.Parameters.AddWithValue("@dni", login.dni);
                cmd.Parameters.AddWithValue("@pass", login.pass);


                tabla.Load(cmd.ExecuteReader());

                if (tabla.Rows.Count > 0)
                {
                    status = true;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return status;
        }

        public bool ActualizarLogin(string sp_nombre, usuarioLogin login)
        {
            bool status = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", login.dni);
                cmd.Parameters.AddWithValue("@nom_usuario", login.nom_usuario);
                cmd.Parameters.AddWithValue("@pass", login.pass);

                cmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return status;
        }


        public bool DeleteLogin(string sp_nombre, int dni)
        {
            bool status = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);


                cmd.ExecuteNonQuery();
                status = true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return status;
        }

        public bool ValidarSeguridadPass(string pass)
        {
            bool mayusculas = false;
            bool minusculas = false;
            bool numero = false;
            bool caracter = false;
            double tamaño_contraseña = 10;
            if (pass.Length >= tamaño_contraseña)
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (Char.IsUpper(pass, i))
                    {
                        mayusculas = true;
                    }
                    else if (Char.IsLower(pass, i))
                    {
                        minusculas = true;
                    }
                    else if (Char.IsDigit(pass, i))
                    {
                        numero = true;
                    }
                    else
                    {
                        caracter = true;
                    }
                }
            }
            if (mayusculas && minusculas && numero && caracter)
            {
                return true;
            }
            return false;
        }

        public bool ConsultarExistencia(string sp_nombre, int dni)
        {
            bool status = false;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable tabla = new DataTable();

                cmd.Parameters.AddWithValue("@dni", dni);

                tabla.Load(cmd.ExecuteReader());

                if (tabla.Rows.Count > 0)
                {
                    status = true;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return status;
        }



        public DataTable ListarClientes(string sp_nombre)
        {
            DataTable tabla = new DataTable();

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                tabla.Load(cmd.ExecuteReader());
                cnn.Close();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return tabla;


        } // lista todos los clientes

        public DataTable ListarClientes(string sp_nombre, int dni)
        {
            DataTable tabla = new DataTable();

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);

                tabla.Load(cmd.ExecuteReader());
                cnn.Close();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return tabla;
        } // este es filtrado por un dni

        public DataTable ConsultarCuentasPorDNI(int dni, string sp_nombre)
        {
            DataTable tabla = new DataTable();

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);

                tabla.Load(cmd.ExecuteReader());
                cnn.Close();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return tabla;


        }

        public bool AgregarDetalleaClienteExistente(Cliente miCliente, string sp_nombre) // en uso OK
        {
            bool ok = true;

            try
            {
                cnn.Open();
                int cod_Cliente = miCliente.idCliente;

                foreach (Cuenta item in miCliente.Cuentas)
                {
                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.CommandText = sp_nombre; // inserta sp detalle
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@cbu", item.Cbu);
                    cmdDetalle.Parameters.AddWithValue("@id_tipo", item.tpCuenta.id); // desde swagger no levanta el id tipo cuenta porque viene del cbo
                    cmdDetalle.Parameters.AddWithValue("@saldo", item.Saldo);
                    cmdDetalle.Parameters.AddWithValue("@ultimoMov", item.UltimoMovimiento);
                    cmdDetalle.Parameters.AddWithValue("@id_cliente", cod_Cliente);

                    cmdDetalle.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                return ok = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;

        }

        public DataTable ObtenerEstadoCivil(string sp_nombre)
        {
            DataTable tabla = new DataTable();

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp_nombre, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                tabla.Load(cmd.ExecuteReader());
                cnn.Close();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return tabla;
        } // para cargar el combo

        public bool TransferirEntreMisCuentas(List<Cuenta> transfer, string sp_nombre)
        {
            bool ok = true;
            int contador = 0;

            foreach (Cuenta cuenta in transfer)

            {
                try
                {
                    if (contador == 0)
                    {
                        Origen = cuenta.Cbu;
                        Importe = cuenta.Saldo; // viaja comosaldo pero es elmonto a trabsferir, no elsaldoreal de la cuenta

                    }
                    if (contador == 1)
                    {
                        Destino = cuenta.Cbu;
                    }
                    contador++;
                }
                catch (Exception ex)
                {

                }
            }
            // ya tengo los valores de origen, destino e importe

            try
            {
                SqlCommand cmdCuenta = new SqlCommand();
                cnn.Open();
                cmdCuenta.Connection = cnn;

                cmdCuenta.CommandType = CommandType.StoredProcedure;
                cmdCuenta.CommandText = sp_nombre;


                cmdCuenta.Parameters.AddWithValue("@cbu_Origen", Origen);
                cmdCuenta.Parameters.AddWithValue("@cbu_Destino", Destino);
                cmdCuenta.Parameters.AddWithValue("@importe", Importe);

                cmdCuenta.ExecuteNonQuery();



            }
            catch (Exception)
            {

                return ok = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;

        }

        public string VerEstadoCivil(int dni, string sp_nombre)
        {
            string estado = "";

            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmdEstado = new SqlCommand();


            cmdEstado.Connection = cnn;
            cmdEstado.CommandText = sp_nombre;
            cmdEstado.CommandType = CommandType.StoredProcedure;
            cmdEstado.Parameters.AddWithValue("@dni", dni);


            dt.Load(cmdEstado.ExecuteReader());
            cnn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                estado = dt.Rows[0]["nom_estado"].ToString();
            }

            return estado;
        }

        public string VerMail(int dni, string sp_nombre)
        {
            string mail = "";

            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmdEstado = new SqlCommand();


            cmdEstado.Connection = cnn;
            cmdEstado.CommandText = sp_nombre;
            cmdEstado.CommandType = CommandType.StoredProcedure;
            cmdEstado.Parameters.AddWithValue("@dni", dni);


            dt.Load(cmdEstado.ExecuteReader());
            cnn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                mail = dt.Rows[0]["mail"].ToString();
            }

            return mail;
        }

        public bool ModificarMail(int dni, string sp_nombre, string nuevoMail)
        {
            bool confirmacion = false;


            try
            {


                cnn.Open();
                SqlCommand cmdEstado = new SqlCommand();


                cmdEstado.Connection = cnn;
                cmdEstado.CommandText = sp_nombre;
                cmdEstado.CommandType = CommandType.StoredProcedure;
                cmdEstado.Parameters.AddWithValue("@dni", dni);
                cmdEstado.Parameters.AddWithValue("@nuevoMail", nuevoMail);

                cmdEstado.ExecuteNonQuery();

                cnn.Close();
                confirmacion = true;

            }
            catch (Exception ex)
            {

            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return confirmacion;


        }

        public bool ModificarEstadoCivil(int dni, string sp_nombre, int nuevoEstadoCivil)
        {
            bool confirmacion = false;

            try
            {
                cnn.Open();
                SqlCommand cmdEstado = new SqlCommand();


                cmdEstado.Connection = cnn;
                cmdEstado.CommandText = sp_nombre;
                cmdEstado.CommandType = CommandType.StoredProcedure;
                cmdEstado.Parameters.AddWithValue("@dni", dni);
                cmdEstado.Parameters.AddWithValue("@nuevoEstadoCivil", nuevoEstadoCivil);

                cmdEstado.ExecuteNonQuery();

                cnn.Close();
                confirmacion = true;

            }
            catch (Exception ex)
            {

            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return confirmacion;


        }


        //---------- reportes -----------------

        public DataTable ReporteCuentas(string sp)
        {
            try
            {
                SqlCommand cmd = new(sp, cnn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cnn.Open();

                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());

                return tabla;
            }
            catch (Exception)
            {
                throw new Exception("ERROR EN LA CONEXION...");
            }
            finally
            {
                if (cnn.State == System.Data.ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }
        public DataTable ReporteSaldos(string sp, int precio_dolar)
        {
            DataTable tabla = new DataTable();

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@precio_dolar", precio_dolar);

                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return tabla;
        }
        public DataTable ReporteCuentasBaja(string sp, DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();
           // string d = desde.ToString("dd-MM-yyyy");// pasar fecha al reves
            //string h = hasta.ToString("dd-MM-yyyy");//
            string d = desde.ToString("yyyy-MM-dd");// pasar fecha al reves
            string h = hasta.ToString("yyyy-MM-dd");//


            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha_Desde", d);
                cmd.Parameters.AddWithValue("@Fecha_Hasta", h);


                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return tabla;
        }

        public bool GrabarNuevoEstadoCivil(string sp_nombre, string nuevoEstado)
        {

            bool confirmacion = false;

            try
            {
                cnn.Open();
                SqlCommand cmdEstado = new SqlCommand();


                cmdEstado.Connection = cnn;
                cmdEstado.CommandText = sp_nombre;
                cmdEstado.CommandType = CommandType.StoredProcedure;
                cmdEstado.Parameters.AddWithValue("@AgregarEstado", nuevoEstado);

                cmdEstado.ExecuteNonQuery();

                cnn.Close();
                confirmacion = true;

            }
            catch (Exception ex)
            {

            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return confirmacion;

        }


        public bool ModificarNuevoEstadoCivil(string sp_nombre, EstadoCivil miNuevoEstadoCivil)
        {

            bool confirmacion = false;

            try
            {
                cnn.Open();
                SqlCommand cmdEstado = new SqlCommand();


                cmdEstado.Connection = cnn;
                cmdEstado.CommandText = sp_nombre;
                cmdEstado.CommandType = CommandType.StoredProcedure;
                cmdEstado.Parameters.AddWithValue("@idEstadoViejo", miNuevoEstadoCivil.id_estado);
                cmdEstado.Parameters.AddWithValue("@nomNuevoEstado", miNuevoEstadoCivil.nom_estado);
                cmdEstado.ExecuteNonQuery();

                cnn.Close();
                confirmacion = true;

            }
            catch (Exception ex)
            {

            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return confirmacion;


        }

        }
    }
