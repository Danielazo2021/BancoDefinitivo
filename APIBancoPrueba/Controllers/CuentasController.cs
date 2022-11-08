using Banco_BibliotecaDDL.Dominio;
using Banco_BibliotecaDDL.Servicios;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBancoPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentasController : ControllerBase
    {
        private IServicio factory;
        public CuentasController()
        {
            factory = new Servicio();
        }

        [HttpGet("/ProximoCBU")]
        public IActionResult GetCliente()
        {
            try
            {
                return Ok(factory.ObtenerProximoCbu());
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }



        // POST api/<CuentasController>
        [HttpPost("/AgregaCuentaSola")]
        public IActionResult PostCliente(Cliente miCliente)
        {
            try
            {
                if (miCliente == null)
                {
                    return BadRequest("Datos de Cliente incorrectos!");
                }

                return Ok(factory.AgregarDetalleaClienteExistente(miCliente));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/ConsultaCuentasPorDNI")]
        public IActionResult GetCuentasporDNI([FromBody] int dni) // tenia el dni y lo saque // es un metodo get, pero lo mando por post para que tenga parametro dni
        {

            try
            {
                if (dni == 0)
                {
                    return BadRequest("Datos de Cliente incorrectos!");
                }

                // serializar
                var json = factory.ConsultarCuentasPorDNI(dni); // ver porque no llega el dni
                var respuesta = JsonConvert.SerializeObject(json);


                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }




        //ver que paso con el get cuentas


        [HttpPost("/RealizarTransferencia")]
        public IActionResult PostTransferencia(List<Cuenta> Transfer)
        {
            try
            {
                if (Transfer == null)
                {
                    return BadRequest("Datos de Cliente incorrectos!");
                }

                return Ok(factory.TransferirEntreMisCuentas(Transfer));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

    }
}
