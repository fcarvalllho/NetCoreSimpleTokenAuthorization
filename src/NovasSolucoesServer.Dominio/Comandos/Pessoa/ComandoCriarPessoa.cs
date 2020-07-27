using Flunt.Notifications;
using Flunt.Validations;
using NovasSolucoesServer.Dominio.Comandos.Contratos;
using System;

namespace NovasSolucoesServer.Dominio.Comandos.Pessoa
{
    public class ComandoCriarPessoa : Notifiable, IComando
    {

        public ComandoCriarPessoa(string nome, string email, DateTime? dataDeCadastro)
        {
            this.Nome = nome;
            this.Email = email;
            this.DataDeCadastro = dataDeCadastro ?? new DateTime();
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime? DataDeCadastro { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .IsNotNull(Nome, "Nome", "Por favor informe o nome do usuário.")
                .IsNotNull(Email, "Email", "Por favor informe o email do usuário.")
                );
        }
    }
}
