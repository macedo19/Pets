using System;
namespace EcommerceAPI.Models{

    public class ProdutoVendido {
        public ProdutoVendido() => CriadoEm = DateTime.Now;

        public string ProdutosComprados { get; set; }

        public float PrecoTotal { get; set; }

        public int QuantidadeItens { get; set; }

        public DateTime CriadoEm {get; set;}
        
    }
}