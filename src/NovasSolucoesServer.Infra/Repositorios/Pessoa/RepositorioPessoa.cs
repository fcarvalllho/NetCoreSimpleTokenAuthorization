using NovasSolucoesServer.Dominio.Entidades;
using NovasSolucoesServer.Dominio.Repositorios;
using NovasSolucoesServer.Infra.Contexto;
using System.Linq;

namespace NovasSolucoesServer.Infra.Repositorios.Pessoa
{
    public class RepositorioPessoa : IRepositorioPessoa
    {
        private contexto dbContext { get; set; }

        public RepositorioPessoa()
        {
            dbContext = new contexto();
        }

        public EntidadePessoa ObterPessoa(string email, string nome)
        {
            return dbContext.dbPessoas.Where(me => me.Nome.Equals(nome) || me.Email.Equals(email)).FirstOrDefault();
        }

        public void Criar(EntidadePessoa pessoa)
        {
            dbContext.AdicionarPessoa(pessoa);
        }
    }
}
