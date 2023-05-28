namespace Garage.WSGerenciaUsuario.Model
{

    [Serializable]
    public class FormularioCadastraUsuarioPessoaFisica
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime? DataNascimento { get; set; }
        public string Cpf { get; set; } = string.Empty;
        public string EmailAcesso { get; set; } = string.Empty;
        public string SenhaAcesso { get; set; } = string.Empty;
        public string TelefoneContato { get; set; } = string.Empty;
        public FormularioEndereco? Endereco { get; set; }
    }

    [Serializable]
    public class FormularioEndereco
    {
        public string Rua { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
    }
}
