namespace EcommerceAPI.Models{

    public class Produto {
        public string Descricao { get; set; }

        public float PrecoCompra { get; set; }

        public float PrecoVenda { get; set; }

        public int Estoque { get; set; }
    }
}