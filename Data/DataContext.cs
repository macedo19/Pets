using EcommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Data{
    public class DataContext : DbContext{
        //Construtor
        
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        //Lista de propriedades das classes que vão virar tabelas no banco
    }
}