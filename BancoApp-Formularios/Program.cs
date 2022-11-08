using bacnoApp_winForm;
using BancoApp_Formularios.Presentacion;
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
            Application.Run(new Form_Inicio_de_Sesion()); //
        }
    }
}