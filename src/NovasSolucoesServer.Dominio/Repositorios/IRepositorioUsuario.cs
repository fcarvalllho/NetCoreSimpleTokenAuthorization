using NovasSolucoesServer.Dominio.Entidades;

namespace NovasSolucoesServer.Dominio.Repositorios
{
    public interface IRepositorioUsuario
    {
        void Criar(EntidadeUsuario Usuario);
        EntidadeUsuario ObterUsuario(string Usuario, string Senha);
    }
}
