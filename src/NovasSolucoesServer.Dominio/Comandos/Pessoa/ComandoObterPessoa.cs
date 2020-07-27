using Flunt.Notifications;
using Flunt.Validations;
using NovasSolucoesServer.Dominio.Comandos.Contratos;

namespace NovasSolucoesServer.Dominio.Comandos.Pessoa
{
    public class ComandoObterPessoa : Notifiable, IComando
    {
        public ComandoObterPessoa(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        public string Nome { get; set; }
        public string Email { get; set; }

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
