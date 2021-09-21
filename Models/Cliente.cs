
namespace EcommerceAPI.Models{
    
    public class Cliente{
        
        public int RG { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
        
        public string Endereco { get; set; }

        public int NumeroEndereco { get; set; }

        public string Bairro { get; set; }
        
        public string Cidade { get; set; }
    }
}