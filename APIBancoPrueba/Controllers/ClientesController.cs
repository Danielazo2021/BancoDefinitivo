using Microsoft.AspNetCore.Mvc;
using Banco_BibliotecaDDL.Servicios;
using Banco_BibliotecaDDL.Dominio;
using Banco_Reportes.ENTIDADES;
using System.Data;
using System;
using Banco_BibliotecaDDL.DataAccess;
using System.Net;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBancoPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IServicio factory;
        public ClientesController()
        {
            factory = new Servicio();
            
        }
        // GET: api/<UsuariosController>
        [HttpGet("/ListaClientes")]
        public IActionResult GetClientes()
        {
            DataTable clientes = null;

            List<Cliente> clientesList = new List<Cliente>();
            try
            {
                clientes = factory.ListarClientes();

                for (int i = 0; i < (clientes.Rows.Count); i++)
                {
                    Cliente miCliente = new Cliente();

                    miCliente.idCliente = Convert.ToInt32(clientes.Rows[i]["id_cliente"]);
                    miCliente.nombre = clientes.Rows[i]["nom_cliente"].ToString();
                    miCliente.apellido = clientes.Rows[i]["ape_cliente"].ToString();
                    miCliente.dni = Convert.ToInt32(clientes.Rows[i]["dni"]);

                    clientesList.Add(miCliente);
                }

                return Ok(clientesList);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }



        // GET api/<UsuariosController>/5
        [HttpGet("{dni}")]


        public IActionResult GetClientePorDNI(int dni)
        {
            DataTable clientes = new();

            List<Cliente> clientesList = new List<Cliente>();
            try
            {
                clientes = factory.ListarClientes(dni);

                for (int i = 0; i < (clientes.Rows.Count); i++)
                {
                    Cliente miCliente = new Cliente();

                    miCliente.idCliente = Convert.ToInt32(clientes.Rows[i]["id_cliente"]);
                    miCliente.nombre = clientes.Rows[i]["nom_cliente"].ToString();
                    miCliente.apellido = clientes.Rows[i]["ape_cliente"].ToString();
                    miCliente.dni = Convert.ToInt32(clientes.Rows[i]["dni"]);

                    clientesList.Add(miCliente);
                }

                return Ok(clientesList);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/ProximoID")] 

        public IActionResult GetCliente()
        {
            
            try
            {


                return Ok(factory.ObtenerProximo());
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }


        // mail
        [HttpPost("/VerMail")]

        public IActionResult PostVerMail([FromBody]int dni)
        {
            try
            {
                if (dni == 0)
                {
                    return BadRequest("Datos de Cliente incorrectos!");
                }
                string mail = factory.VerMail(dni);

                return Ok(mail);


            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/ModificarMail")]

        public IActionResult PostModificarrMail([FromBody]Cliente cliente)
        {
            try
            {
                if (cliente.dni == 0 || cliente.mail == "")
                {
                    return BadRequest("Datos de Cliente incorrectos!");
                }

                return Ok(factory.ModificarMail(cliente.dni, cliente.mail));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        } // ver



        // POST api/<UsuariosController>
        [HttpPost]

        public IActionResult PostCliente(Cliente miCliente)
        {
            try
            {
                if (miCliente == null)
                {
                    return BadRequest("Datos de Cliente incorrectos!");
                }

                return Ok(factory.GrabaMaestroDetalle(miCliente));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

       
    }
}

