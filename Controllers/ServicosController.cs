using EcommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers {
    public class ServicosControllers {
        // Rota para usa da classe
        [ApiController]
        [Route("ecommerceapi/servicos")]
        public class ProdutosController : ControllerBase{

            //POST: ecommerceapi/servicos/cadastrar
            [HttpPost]
            [Route("cadastrar")]
            public Servicos CadastrarServicos(Servicos servicos){
                return servicos ;
            }
        }
    }
}