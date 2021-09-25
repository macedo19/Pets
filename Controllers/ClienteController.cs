using System;
using System.Collections.Generic;
using System.Linq;
using EcommerceAPI.Models;
using EcommerceAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers{

    // Rota para usa da classe
    [ApiController]
    [Route("ecommerceapi/cliente")]
    public class ClienteController : ControllerBase{

        private readonly DataContext _context;
        
        public ClienteController(DataContext context) => _context = context;

        //POST: ecommerceapi/cliente/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult CadastrarCliente([FromBody] Cliente cliente){
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Created(" ", cliente);
        }
    }
}