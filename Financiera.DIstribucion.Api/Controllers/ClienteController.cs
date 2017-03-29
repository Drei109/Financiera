using ClassLibrary1.Repositorios;
using Financiera.DIstribucion.Api.Models;
using Financiera.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Financiera.DIstribucion.Api.Controllers
{
    public class ClienteController : ApiController
    {
        [HttpGet]
        public List<dtoCliente> ListarCliente()

        {
            try
            {
                IRepositorioGeneral<Cliente> repCliente = new RepositorioGeneral<Cliente>();
                var clientes = repCliente.Listar();
                List<dtoCliente> lista = (from c in clientes
                                          select new dtoCliente()
                                          {
                                              CodigoCliente = c.CodigoCliente,
                                              NombreCliente = c.NombreCliente
                                          }
                    ).ToList();
                return lista;
            }
            catch (Exception ie_excepcion)
            {

                throw ie_excepcion; 
            }

        }



        [HttpGet]
        [Route("api/cliente/{ai_cod_cliente}")]
        public IHttpActionResult BuscarClientePorCodigo(int ai_cod_cliente)
        {
            IRepositorioGeneral<Cliente> repCliente = new RepositorioGeneral<Cliente>();
            var consulta = repCliente.Buscar(ai_cod_cliente);
            dtoCliente cliente = new dtoCliente()
            {
                CodigoCliente = consulta.CodigoCliente,
                NombreCliente = consulta.NombreCliente
            };              
            return Ok(cliente);

        }



        // GET: api/Cliente
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Cliente/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Cliente
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Cliente/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Cliente/5
        //public void Delete(int id)
        //{
        //}
    }
}
