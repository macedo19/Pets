using EcommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Data {
    public class DataContext : DbContext {
        public DataContext()
        {
        }

        //Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options){}  

        //Lista de propriedades das classes que vão virar tabelas no banco
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Servico> Servicos {get; set;}
        public DbSet<Horarios> Horarios {get; set;}

        
        public static void AddHorario(){
            var _context = new DataContext();
            AdicionarHorario(_context, 0, 08);
            AdicionarHorario(_context, 0, 09);
            AdicionarHorario(_context, 0, 10);
            AdicionarHorario(_context, 0, 11);
            AdicionarHorario(_context, 0, 12);
            AdicionarHorario(_context, 0, 13);
            AdicionarHorario(_context, 0, 14);
            AdicionarHorario(_context, 0, 15);
            AdicionarHorario(_context, 0, 16);
            AdicionarHorario(_context, 0, 17);  

            _context.SaveChanges();          
        }
        private static void AdicionarHorario(DataContext _context, int disponivel, int hora){
            _context.Horarios.Add( new Models.Horarios(){
                HorarioMarcado = disponivel,
                Hora = hora
            });
        }

        
    }
}