using bacnoApp_winForm;
using BancoApp_Formularios.Presentacion;
using BancoApp_Formularios.Presentacion.Formularios_Auxiliares;
using BancoApp_Formularios.Presentacion.Login;
using CRUDbanco;
using CRUDbanco.Presentacion;

namespace BancoApp_Formularios
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Inicio_de_Sesion());
            //Estado civil//
            //Application.Run(new Form_DatosDeContacto());
             Application.Run(new Form_EstadoCivil());
            //Login//
            //App//lication.Run(new Form_Alta_Login());
            //Application.Run(new Form_Baja_Login());
            //Application.Run(new Form_Login());
            //Application.Run(new Form_ModificarLogin());
            //cliente//
            //Application.Run(new Form_AltaCliente());
            // Application.Run(new Form_MenuPrincipal());
            //Application.Run(new Form_MostrarDatos());
            //Application.Run(new Form_Movimiento_de_saldos());
            // Application.Run(new Form_NuevaCuenta_ClienteExistente());
          //  Application.Run(new Form_MenuPrincipal());



            //Application.Run(new Form_EstadoCivil());
        }
    }
}