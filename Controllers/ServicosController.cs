using EcommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers {

    // Rota para usa da classe
    [ApiController]
    [Route("ecommerceapi/servicos")]
    public class ServicoController : ControllerBase{

        //POST: ecommerceapi/servicos/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public Servico CadastrarServicosAction (Servico servico){

            return servico ;
        }

        //List


        //Delete

        //Update
    }
    
}