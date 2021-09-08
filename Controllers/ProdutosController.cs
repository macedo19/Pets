using EcommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers {
    public class ProdutosControllers {
        // Rota para usa da classe
        [ApiController]
        [Route("ecommerceapi/produtos")]
        public class ProdutosController : ControllerBase{

            //POST: ecommerceapi/produtos/cadastrar
            [HttpPost]
            [Route("cadastrar")]
            public Produto CadastrarProduto(Produto produto){
                return produto ;
            }
        }
    }
}