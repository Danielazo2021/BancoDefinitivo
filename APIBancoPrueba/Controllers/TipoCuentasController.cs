using Banco_BibliotecaDDL.Dominio;
using Banco_BibliotecaDDL.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBancoPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoCuentasController : ControllerBase
    {
        private IServicio factory; //punto de acceso a la API

        public TipoCuentasController()
        {
            factory = new Servicio();
        }


        [HttpGet("/ComboEstadoCivil")] // usa el mismo controller pero con otro get
        public IActionResult GetEstadoCivil()
        {
            DataTable dTEstadoCivil;
            List<EstadoCivil> lstEstadoCivil = new List<EstadoCivil>();
            try
            {
                dTEstadoCivil = factory.ObtenerEstadoCivil();
                for (int i = 0; i < (dTEstadoCivil.Rows.Count); i++)
                {
                    EstadoCivil miEstado = new EstadoCivil();

                    miEstado.id_estado = Convert.ToInt32(dTEstadoCivil.Rows[i]["id_estado"]);
                    miEstado.nom_estado = dTEstadoCivil.Rows[i]["nom_estado"].ToString();

                    lstEstadoCivil.Add(miEstado);
                }

                return Ok(lstEstadoCivil);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        [HttpGet("/tpCuenta")]
        public IActionResult GetProductos()
        {
            List<TipoCuenta> lst = new();
            try
            {
                lst = factory.ObtenerCuentas();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

    }
}
