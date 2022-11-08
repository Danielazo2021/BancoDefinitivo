using Banco_BibliotecaDDL.Servicios;
using Banco_BibliotecaDDL.Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace APIBancoPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IServicio factory;

        public LoginController()
        {
            factory = new Servicio();
        }



        // GET api/<LoginController>/5
        [HttpGet]//"{dni}, {pass}")] // le meti el validar //host 7224
        public IActionResult GetValidarLogin(int dni, string pass)
        {
            usuarioLogin miUsuario = new usuarioLogin();
            miUsuario.dni = dni;
            miUsuario.pass = pass;

            bool estado = factory.validarLogin(miUsuario);
            if (estado)
            {
                return Ok(estado + (" - Acceso concedido"));
            }
            else
            {
                return StatusCode(500, " - Usuario o Contraseña incorrecto");
            }
        }



        // POST api/<LoginController>
        [HttpPost("/nuevoUsuario")]
        public IActionResult PostSaveLogin(usuarioLogin miUsuario)
        {
            try
            {
                if (miUsuario == null)
                {
                    return BadRequest("Datos de usuario incorrectos!");
                }

                if (factory.ValidarSeguridadPass(miUsuario.pass))
                {
                    bool estado = factory.RegistrarLogin(miUsuario);
                    if (estado)
                    {
                        return Ok(estado + (" - Nuevo usuario registrado correctamente!!"));
                    }
                    return StatusCode(500, " - Datos incorrectos");
                }
                else
                {
                    return StatusCode(500, " - Datos incorrectos, la contraseña no cumple los requisitos de al menos 1 caracter, 1 mayuscula, 1 miuscula, 1 numero y una longitud de 10 digitos");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, " - Datos incorrectos");
            }

        }

        [HttpPost("/ValidarUsuario")]
        public IActionResult ValidarUsuario(usuarioLogin miUsuario)
        {
            try
            {
                if (miUsuario == null)
                {
                    return BadRequest("Datos de usuario incorrectos!");
                }

                if (factory.validarLogin(miUsuario))
                {
                    return Ok("acceso concedido");
                }
                else
                {
                    return StatusCode(500, " - Datos incorrectos");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, " - Datos incorrectos");
            }

        }







        // PUT api/<LoginController>/5
        [HttpPut()]
        public IActionResult PutActualizarLogin(int dni, string nom_usuario, string pass)
        {
            if (dni < 0)
            {
                return StatusCode(500, "Datos incorrectos / registro inexistente");
            }
            else if (!factory.ConsultarExistencia(dni))
            {
                return StatusCode(500, "Datos incorrectos / registro inexistente");
            }

            usuarioLogin miUsuario = new usuarioLogin();

            if (factory.ValidarSeguridadPass(pass))
            {

                miUsuario.dni = dni;
                miUsuario.nom_usuario = nom_usuario;
                miUsuario.pass = pass;


                bool estado = factory.ActualizarLogin(miUsuario);
                if (estado)
                {
                    return Ok(estado + (" - usuario actualizado correctamente!!"));
                }
                return StatusCode(500, " - Datos incorrectos");
            }
            else
            {
                return StatusCode(500, " - Datos incorrectos, la contraseña no cumple los requisitos de al menos 1 caracter, 1 mayuscula, 1 miuscula, 1 numero y una longitud de 10 digitos");
            }

        }




        // DELETE api/<LoginController>/5
        [HttpDelete()]
        public IActionResult DeleteLogin(int dni)
        {
            if (dni < 0)
            {
                return StatusCode(500, "Datos incorrectos / registro inexistente");
            }

            bool estado = factory.DeleteLogin(dni);
            if (estado)
            {
                return Ok(estado + (" - el dni: " + dni + " ya no existe en la base de datos"));
            }
            else
            {
                return StatusCode(500, "Datos incorrectos / registro inexistente");
            }

        }
    }
}
