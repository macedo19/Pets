using System;
using System.Collections.Generic;
using System.Linq;
using EcommerceAPI.Models;
using EcommerceAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{

    // Rota para usa da classe
    [ApiController]
    [Route("ecommerceapi/cliente")]
    public class ClienteController : ControllerBase
    {

        private readonly DataContext _context;

        public ClienteController(DataContext context) => _context = context;

        //POST: ecommerceapi/cliente/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult CadastrarCliente([FromBody] Cliente cliente)
        {

            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Created(" ", cliente);
        }

        // GET: ecommerceapi/cliente/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Clientes.ToList());

        // GET: ecommerceapi/cliente/buscar/id
        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar([FromRoute] int id)
        {
            Cliente cliente = _context.Clientes.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(cliente);
            }
        }

        // DELETE: ecommerceapi/cliente/deletar/id
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            else
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
                return Ok(_context.Clientes.ToList());
            }
        }

        // PUT: ecommerceapi/cliente/atualizar
        [HttpPut]
        [Route("atualizar")]
        public IActionResult Atualizar([FromBody] Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
    }
}