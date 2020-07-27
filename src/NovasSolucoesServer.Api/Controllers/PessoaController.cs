using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NovasSolucoesServer.Dominio.Comandos;
using NovasSolucoesServer.Dominio.Comandos.Pessoa;
using NovasSolucoesServer.Dominio.Operadores.Pessoa;

namespace NovasSolucoesServer.Api.Controllers
{
    [Authorize]
    [Route("api/pessoa")]
    public class PessoaController : ControllerBase
    {

        [HttpGet]
        [Route("obter")]
        [Authorize(Roles = "employee,manager")]
        public ComandoGenericoResposta Obter([FromBody] ComandoObterPessoa comando, [FromServices] OperadorPessoa operador)
        {
            return (ComandoGenericoResposta)operador.Exec(comando);
        }


        [HttpPost]
        [Route("criar")]
        [Authorize(Roles = "manager")]
        public ComandoGenericoResposta Criar([FromBody] ComandoCriarPessoa comando, [FromServices] OperadorPessoa operador)
        {
            return (ComandoGenericoResposta)operador.Exec(comando);
        }


    }
}