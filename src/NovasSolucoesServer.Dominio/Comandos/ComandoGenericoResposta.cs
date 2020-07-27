using NovasSolucoesServer.Dominio.Comandos.Contratos;

namespace NovasSolucoesServer.Dominio.Comandos
{
    public class ComandoGenericoResposta : IComandoResposta
    {

        public ComandoGenericoResposta()
        {

        }

        public ComandoGenericoResposta(bool sucesso, string mensagem, object data)
        {
            this.Sucesso = sucesso;
            this.Mensagem = mensagem;
            this.Data = data;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Data { get; set; }
    }
}
