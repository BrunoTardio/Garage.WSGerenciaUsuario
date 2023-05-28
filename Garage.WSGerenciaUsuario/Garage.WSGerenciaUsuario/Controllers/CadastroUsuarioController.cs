using Garage.WSGerenciaUsuario.Facade;
using Garage.WSGerenciaUsuario.Model;
using Microsoft.AspNetCore.Mvc;

namespace Garage.WSGerenciaUsuario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroUsuarioController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
       {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly ILogger<CadastroUsuarioController> _logger;
        private readonly ICadastroUsuarioFacade _cadastroUsuarioFacade;


        public CadastroUsuarioController(
             ILogger<CadastroUsuarioController> logger,
            ICadastroUsuarioFacade cadastroUsuarioFacade)

        {
            _logger = logger;
            _cadastroUsuarioFacade = cadastroUsuarioFacade;
        }


        [HttpPost(Name = "Cadastra/Usuario")]
        public Task<bool> CadastraUsuario(FormularioCadastraUsuarioPessoaFisica formularioCadastraUsuario)
             => _cadastroUsuarioFacade.CadastraUsuario(formularioCadastraUsuario);

    }
}
