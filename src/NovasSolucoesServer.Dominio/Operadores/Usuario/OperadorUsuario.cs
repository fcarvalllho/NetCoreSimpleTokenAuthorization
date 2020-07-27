using Flunt.Notifications;
using NovasSolucoesServer.Dominio.Comandos;
using NovasSolucoesServer.Dominio.Comandos.Contratos;
using NovasSolucoesServer.Dominio.Comandos.Usuario;
using NovasSolucoesServer.Dominio.Entidades;
using NovasSolucoesServer.Dominio.Operadores.Contrato;
using NovasSolucoesServer.Dominio.Repositorios;

namespace NovasSolucoesServer.Dominio.Operadores.Usuario
{
    public class OperadorUsuario : Notifiable,
        IOperador<ComandoCriarUsuario>,
        IOperador<ComandoObterUsuario>
    {

        private readonly IRepositorioUsuario _repositorioUsuario;

        public OperadorUsuario(IRepositorioUsuario repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }

        public IComandoResposta Exec(ComandoObterUsuario comando)
        {
            comando.Validate();
            if (comando.Invalid)
                return new ComandoGenericoResposta(false, "Erro", comando.Notifications);

            var usuario = _repositorioUsuario.ObterUsuario(comando.Usuario, comando.Senha);

            return new ComandoGenericoResposta(true, "Sucesso", usuario);
        }

        public IComandoResposta Exec(ComandoCriarUsuario comando)
        {
            comando.Validate();
            if (comando.Invalid)
                return new ComandoGenericoResposta(false, "Erro", comando.Notifications);

            var novoUsuario = new EntidadeUsuario(comando.Usuario, comando.Senha, comando.Regra);

            _repositorioUsuario.Criar(novoUsuario);

            return new ComandoGenericoResposta(true, "Sucesso", comando.Notifications);
        }
    }
}
