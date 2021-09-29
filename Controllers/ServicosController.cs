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
    [Route("ecommerceapi/servicos")]
    public class ServicoController : ControllerBase
    {

        private readonly DataContext _context;

        public ServicoController(DataContext context) => _context = context;

        // POST: ecommerceapi/servicos/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Servico servico)
        {
            Horarios horario = _context.Horarios.Find(servico.Hora);
            if (horario.HorarioMarcado == 0)
            {
                horario.HorarioMarcado = 1;
                horario.Hora = servico.Hora;
                _context.SaveChanges();
            }
            _context.Servicos.Add(servico);
            _context.SaveChanges();
            return Created("", servico);
        }

        // GET: ecommerceapi/servicos/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult List() => Ok(_context.Servicos.ToList());

        // POST: ecommerceapi/servicos/buscar/id
        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar([FromRoute] int cpf)
        {
            Servico servico = _context.Servicos.Find(cpf);
            if (servico == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(servico);
            }
        }

        // DELETE: ecommerceapi/servicos/deletar/id
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Servico servico = _context.Servicos.FirstOrDefault(servico => servico.Id == id);
            if (servico == null)
            {
                return NotFound();
            }
            else
            {
                _context.Servicos.Remove(servico);
                _context.SaveChanges();
                return Ok(_context.Servicos.ToList());
            }
        }

        // PUT: ecommerceapi/servicos/atualizar
        [HttpPut]
        [Route("atualizar")]
        public IActionResult Atualizar([FromBody] Servico servico)
        {
            _context.Servicos.Update(servico);
            _context.SaveChanges();
            return Ok(servico);
        }
    }
}