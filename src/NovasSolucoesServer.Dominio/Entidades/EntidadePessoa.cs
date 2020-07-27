using System;

namespace NovasSolucoesServer.Dominio.Entidades
{
    public class EntidadePessoa : EntidadeBase
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime? DataDeCadastro { get; private set; }

        public EntidadePessoa(string nome, string email, DateTime? dataDeCadastro)
        {
            this.Nome = nome;
            this.Email = email;
            this.DataDeCadastro = dataDeCadastro ?? new DateTime();
        }

    }
}
