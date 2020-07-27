using Flunt.Notifications;
using NovasSolucoesServer.Dominio.Comandos;
using NovasSolucoesServer.Dominio.Comandos.Contratos;
using NovasSolucoesServer.Dominio.Comandos.Pessoa;
using NovasSolucoesServer.Dominio.Entidades;
using NovasSolucoesServer.Dominio.Operadores.Contrato;
using NovasSolucoesServer.Dominio.Repositorios;

namespace NovasSolucoesServer.Dominio.Operadores.Pessoa
{
    public class OperadorPessoa : Notifiable,
        IOperador<ComandoCriarPessoa>,
        IOperador<ComandoObterPessoa>
    {

        private readonly IRepositorioPessoa _repositorioPessoa;

        public OperadorPessoa(IRepositorioPessoa repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }

        public IComandoResposta Exec(ComandoCriarPessoa comando)
        {
            comando.Validate();
            if (comando.Invalid)
                return new ComandoGenericoResposta(false, "Erro", comando.Notifications);

            var novaPessoa = new EntidadePessoa(comando.Nome, comando.Email, comando.DataDeCadastro);

            _repositorioPessoa.Criar(novaPessoa);

            return new ComandoGenericoResposta(true, "Sucesso", comando.Notifications);
        }

        public IComandoResposta Exec(ComandoObterPessoa comando)
        {
            comando.Validate();
            if (comando.Invalid)
                return new ComandoGenericoResposta(false, "Erro", comando.Notifications);

            var pessoa = _repositorioPessoa.ObterPessoa(comando.Email, comando.Nome);

            return new ComandoGenericoResposta(true, "Sucesso", pessoa);
        }
    }
}
