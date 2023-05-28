using Garage.WSGerenciaUsuario.Model;

namespace Garage.WSGerenciaUsuario.Facade
{
    public interface ICadastroUsuarioFacade
    {

        /// <summary>
        /// Efetua o cadastro do usuario ->
        /// Contendo Login de acesso e dados do usuário
        /// </summary>
        /// <param name="formulario"></param>
        /// <returns></returns>
        Task<bool> CadastraUsuario(FormularioCadastraUsuarioPessoaFisica formulario);

        /// <summary>
        /// Efetua a atualizacao dos dados do usuario
        /// Contendo Login de acesso e dados do usuário
        /// </summary>
        /// <param name="formulario"></param>
        /// <returns></returns>
        Task<bool> AtualizaUsuario(FormularioCadastraUsuarioPessoaFisica formulario);

        /// <summary>
        /// Exclui os dados do usuario seguindo a LGPD
        /// </summary>
        /// <param name="formulario"></param>
        /// <returns></returns>
        Task<bool> ExluirUsuario(FormularioCadastraUsuarioPessoaFisica formulario);

        /// <summary>
        /// Exclui os dados do usuario seguindo a LGPD
        /// </summary>
        /// <param name="formulario"></param>
        /// <returns></returns>
        Task<bool> RecuperaUsuario(FormularioCadastraUsuarioPessoaFisica formulario);
    }
    public class CadastroUsuarioFacade : ICadastroUsuarioFacade
    {
        public Task<bool> AtualizaUsuario(FormularioCadastraUsuarioPessoaFisica formulario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CadastraUsuario(FormularioCadastraUsuarioPessoaFisica formulario)
        {


            throw new NotImplementedException();
        }

        public Task<bool> ExluirUsuario(FormularioCadastraUsuarioPessoaFisica formulario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RecuperaUsuario(FormularioCadastraUsuarioPessoaFisica formulario)
        {
            throw new NotImplementedException();
        }
    }
}
