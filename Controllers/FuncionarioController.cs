using EcommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers {
    public class FuncionarioControllers {
        // Rota para usa da classe
        [ApiController]
        [Route("ecommerceapi/funcionario")]
        public class FuncionarioController : ControllerBase{

            //POST: ecommerceapi/funcionario/cadastrar
            [HttpPost]
            [Route("cadastrar")]
            public Funcionario CadastrarFuncionario(Funcionario funcionario){
                return funcionario ;
            }
        }
    }
}