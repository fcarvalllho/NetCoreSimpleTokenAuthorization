using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovasSolucoesServer.Api.Servicos;
using NovasSolucoesServer.Dominio.Comandos;
using NovasSolucoesServer.Dominio.Comandos.Usuario;
using NovasSolucoesServer.Dominio.Entidades;
using NovasSolucoesServer.Dominio.Operadores.Usuario;

namespace NovasSolucoesServer.Api.Controllers
{
    [Route("api/autenticacao")]
    public class AutorizacaoController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> login([FromBody]ComandoObterUsuario comando, [FromServices] OperadorUsuario operador)
        {
            // Recupera o usuário
            var obterUsuario = (ComandoGenericoResposta)operador.Exec(comando);
            var usuario = obterUsuario.Data as EntidadeUsuario;

            // Verifica se o usuário existe
            if (usuario == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            // Gera o Token
            var token = TokenServ.GerarToken(usuario);

            // Oculta a senha
            usuario.EsconderSenha("");

            // Retorna os dados
            return new
            {
                user = usuario,
                token = token
            };
        }
    }
}