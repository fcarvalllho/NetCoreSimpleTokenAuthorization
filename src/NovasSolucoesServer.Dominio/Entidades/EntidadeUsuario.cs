namespace NovasSolucoesServer.Dominio.Entidades
{
    public class EntidadeUsuario : EntidadeBase
    {
        public string Usuario { get; private set; }
        public string Senha { get; private set; }
        public string Regra { get; private set; }

        public EntidadeUsuario(string usuario, string senha, string regra)
        {
            this.Usuario = usuario;
            this.Senha = senha;
            this.Regra = regra;
        }

        public void EsconderSenha(string senha)
        {
            this.Senha = senha;
        }
    }
}
