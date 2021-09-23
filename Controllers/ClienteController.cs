using EcommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers{

    // Rota para usa da classe
    [ApiController]
    [Route("ecommerceapi/cliente")]
    public class ClienteController : ControllerBase{

        //POST: ecommerceapi/cliente/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public Cliente CadastrarCliente(Cliente cliente){
            
            return cliente ;
        }
    }
}