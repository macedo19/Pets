using EcommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers {
    public class ReceitaControllers {
        // Rota para usa da classe
        [ApiController]
        [Route("ecommerceapi/receita")]
        public class ReceitaController : ControllerBase{

            //POST: ecommerceapi/receita/cadastrar
            [HttpPost]
            [Route("cadastrar")]
            public Receita CadastrarServicos(Receita receita){
                return receita ;
            }
        }
    }
}