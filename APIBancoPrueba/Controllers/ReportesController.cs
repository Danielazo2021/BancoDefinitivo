using Banco_BibliotecaDDL.Servicios;
using Banco_Reportes.ENTIDADES;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace APIBancoPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportesController : Controller
    {
        private IServicioReportes factory;
        public ReportesController()
        {
            factory = new ServicioReportes();
        }
        [HttpGet("{dolar}")]
        public IActionResult GetReporteSaldo(int dolar) 
        {
            DataTable reporte_saldos = null;

            List<ReporteSaldos> lista = new List<ReporteSaldos>();

            try
            {
                reporte_saldos = factory.ReporteSaldos(dolar);
                int contador = 0;
                foreach (DataRow item in reporte_saldos.Rows)
                {
                    ReporteSaldos reporteSaldos = new ();

                    reporteSaldos.TipoCuenta = item["nom_cuenta"].ToString(); 
                    reporteSaldos.Saldo = (double)Convert.ToDouble(item["saldo"]);
                    reporteSaldos.ValorPesos = (double)Convert.ToDouble(item["valor_pesos"]);
                    
                    lista.Add(reporteSaldos);
                    contador++;
                }
               
                return Ok(lista);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        } // esta ok

        // endpoin daniel





        [HttpGet("/ReporteCuentas")]
        public IActionResult GetReportClientes()
        {
            DataTable reporte_cuentas = null;

            List<ReporteCuentas> lista = new ();
            try
            {
                reporte_cuentas = factory.ReporteCuentas();

                foreach (DataRow item in reporte_cuentas.Rows)
                {
                    ReporteCuentas rc = new ();

                    rc.Nombre = item["nombre"].ToString();
                    rc.Apellido = item["apellido"].ToString();
                    rc.Dni = Convert.ToInt32(item["dni"]); // Convert.ToInt32(item["dni"].ToString());
                    rc.Cbu = Convert.ToDouble(item["cbu"]);//Convert.ToInt32(item["cbu"].ToString());
                    rc.Saldo = (double)Convert.ToDouble(item["saldo"].ToString());
                    rc.UltimoMovimiento = (DateTime)(item["ultimo_mov"]);
                    //rc.FechaBaja = (DateTime)(item["fecha_baja"]);
                    rc.NombreCuenta = item["tipo_cuenta"].ToString();

                    lista.Add(rc);
                }
                return Ok(lista);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
