using NovasSolucoesServer.Dominio.Comandos.Contratos;

namespace NovasSolucoesServer.Dominio.Operadores.Contrato
{
    public interface IOperador<T> where T : IComando
    {
        IComandoResposta Exec(T comando);
    }
}
