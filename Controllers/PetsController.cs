using EcommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers {
    public class PetsControllers {
        // Rota para usa da classe
        [ApiController]
        [Route("ecommerceapi/pets")]
        public class PetsController : ControllerBase{

            //POST: ecommerceapi/pets/cadastrar
            [HttpPost]
            [Route("cadastrar")]
            public Pets CadastrarPets(Pets pets){
                return pets ;
            }
        }
    }
}