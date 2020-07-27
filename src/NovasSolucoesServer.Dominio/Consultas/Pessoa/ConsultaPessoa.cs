using NovasSolucoesServer.Dominio.Entidades;
using System;
using System.Linq.Expressions;

namespace NovasSolucoesServer.Dominio.Consultas.Pessoa
{
    public static class ConsultaPessoa
    {

        public static Expression<Func<EntidadePessoa, bool>> ObterPessoaPorNome(string nome)
        {
            return x => x.Nome.Equals(nome);
        }

        public static Expression<Func<EntidadePessoa, bool>> ObterPessoaPorEmail(string email)
        {
            return x => x.Email.Equals(email);
        }
    }
}
