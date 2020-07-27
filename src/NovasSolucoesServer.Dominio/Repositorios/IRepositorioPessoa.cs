using NovasSolucoesServer.Dominio.Entidades;

namespace NovasSolucoesServer.Dominio.Repositorios
{
    public interface IRepositorioPessoa
    {
        void Criar(EntidadePessoa Pessoa);
        EntidadePessoa ObterPessoa(string Email, string Nome);
    }
}
