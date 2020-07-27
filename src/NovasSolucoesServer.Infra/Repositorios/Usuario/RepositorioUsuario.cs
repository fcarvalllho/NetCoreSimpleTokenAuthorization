using NovasSolucoesServer.Dominio.Entidades;
using NovasSolucoesServer.Dominio.Repositorios;
using NovasSolucoesServer.Infra.Contexto;
using System.Linq;

namespace NovasSolucoesServer.Infra.Repositorios.Usuario
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private contexto dbContext { get; set; }

        public RepositorioUsuario()
        {
            dbContext = new contexto();
        }

        public void Criar(EntidadeUsuario usuario)
        {
            dbContext.AdicionarUsuario(usuario);
        }

        public EntidadeUsuario ObterUsuario(string usuario, string senha)
        {
            return dbContext.dbUsuarios.Where(me => me.Usuario.Equals(usuario) && me.Senha.Equals(senha)).FirstOrDefault();
        }
    }
}
