using Flunt.Notifications;
using Flunt.Validations;
using NovasSolucoesServer.Dominio.Comandos.Contratos;

namespace NovasSolucoesServer.Dominio.Comandos.Usuario
{
    public class ComandoCriarUsuario : Notifiable, IComando
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Regra { get; set; }

        public ComandoCriarUsuario(string usuario, string Senha, string regra)
        {
            this.Usuario = usuario;
            this.Senha = Senha;
            this.Regra = regra;
        }

        public void Validate()
        {
            AddNotifications(
               new Contract()
               .Requires()
               .IsNotNull(Usuario, "Usuario", "Por favor informe o nome do usuário.")
               .IsNotNull(Usuario, "Senha", "Por favor informe a senha.")
               );
        }
    }
}
