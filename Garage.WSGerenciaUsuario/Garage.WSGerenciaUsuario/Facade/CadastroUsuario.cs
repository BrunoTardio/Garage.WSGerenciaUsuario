using Garage.WSGerenciaUsuario.Model;

namespace Garage.WSGerenciaUsuario.Facade
{
    public interface ICadastroUsuario
    {

        /// <summary>
        /// Efetua o cadastro do usuario ->
        /// Contendo Login de acesso e dados do usuário
        /// </summary>
        /// <param name="formulario"></param>
        /// <returns></returns>
        Task<bool> CadastraUsuario(FormularioCadastraUsuario formulario);

        /// <summary>
        /// Efetua a atualizacao dos dados do usuario
        /// Contendo Login de acesso e dados do usuário
        /// </summary>
        /// <param name="formulario"></param>
        /// <returns></returns>
        Task<bool> AtualizaUsuario(FormularioCadastraUsuario formulario);

        /// <summary>
        /// Exclui os dados do usuario seguindo a LGPD
        /// </summary>
        /// <param name="formulario"></param>
        /// <returns></returns>
        Task<bool> ExluirUsuario(FormularioCadastraUsuario formulario);

        /// <summary>
        /// Exclui os dados do usuario seguindo a LGPD
        /// </summary>
        /// <param name="formulario"></param>
        /// <returns></returns>
        Task<bool> RecuperaUsuario(FormularioCadastraUsuario formulario);
    }
    public class CadastroUsuario : ICadastroUsuario
    {
        public Task<bool> AtualizaUsuario(FormularioCadastraUsuario formulario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CadastraUsuario(FormularioCadastraUsuario formulario)
        {


            throw new NotImplementedException();
        }

        public Task<bool> ExluirUsuario(FormularioCadastraUsuario formulario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RecuperaUsuario(FormularioCadastraUsuario formulario)
        {
            throw new NotImplementedException();
        }
    }
}
