using System;
using System.Collections.Generic;
using System.Linq;
using EcommerceAPI.Models;
using EcommerceAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers{

    // Rota para usa da classe
    [ApiController]
    [Route("ecommerceapi/agenda")]
    public class AgendaController : ControllerBase{

        private readonly DataContext _context;
        
        public AgendaController(DataContext context) => _context = context;

        //POST: ecommerceapi/agenda/iniciar
        [HttpPost]
        [Route("iniciar")]
        public IActionResult IniciarAgenda(){
            AdicionarHorario(_context, 8, 0, 08);
            AdicionarHorario(_context, 9, 0, 09);
            AdicionarHorario(_context, 10, 0, 10);
            AdicionarHorario(_context, 11, 0, 11);
            AdicionarHorario(_context, 12, 0, 12);
            AdicionarHorario(_context, 13, 0, 13);
            AdicionarHorario(_context, 14, 0, 14);
            AdicionarHorario(_context, 15, 0, 15);
            AdicionarHorario(_context, 16, 0, 16);
            AdicionarHorario(_context, 17, 0, 17);  
            _context.SaveChanges();

             return Ok();
        }

        private static void AdicionarHorario(DataContext _context, int horario, int disponivel, int hora)
        {
            _context.Horarios.AddRange(new Horarios[]
            {
                 new Horarios {Horario = horario, HorarioMarcado = disponivel, Hora = hora },
            });
        }

        // GET: ecommerceapi/agenda/listarHorario
        [HttpGet]
        [Route("listarHorario")]
        public IActionResult ListHorario() => Ok(_context.Horarios.ToList());

        // GET: ecommerceapi/agenda/listarHorario
        [HttpGet]
        [Route("listarHorarioDisponivel")]
        public IActionResult ListHorarioDisponiveis() => Ok(_context.Horarios.ToList());
            
        

    }
}