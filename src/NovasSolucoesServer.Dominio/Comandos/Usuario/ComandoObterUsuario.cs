using Flunt.Notifications;
using Flunt.Validations;
using NovasSolucoesServer.Dominio.Comandos.Contratos;

namespace NovasSolucoesServer.Dominio.Comandos.Usuario
{
    public class ComandoObterUsuario : Notifiable, IComando
    {

        public string Usuario { get; set; }
        public string Senha { get; set; }

        public ComandoObterUsuario(string username, string senha)
        {
            this.Usuario = username;
            this.Senha = senha;
        }

        public void Validate()
        {
            AddNotifications(
               new Contract()
               .Requires()
               .IsNotNull(Usuario, "Usuario", "Por favor informe o nome do usuário.")
               .IsNotNull(Senha, "Senha", "Por favor informe a senha do usuário.")
               );
        }
    }
}
