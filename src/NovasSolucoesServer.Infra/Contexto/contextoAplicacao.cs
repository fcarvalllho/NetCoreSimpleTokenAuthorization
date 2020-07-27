using NovasSolucoesServer.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovasSolucoesServer.Infra.Contexto
{
    public class contexto
    {
        public List<EntidadePessoa> dbPessoas { get; private set; }
        public List<EntidadeUsuario> dbUsuarios { get; private set; }

        public contexto()
        {
            dbPessoas = new List<EntidadePessoa>();
            dbPessoas.Add(new EntidadePessoa("Fábio de Paula Carvalho", "fabio.paula@csharp.com.br", DateTime.Now));
            dbPessoas.Add(new EntidadePessoa("Diego Alves Torres", "diego.torres@csharp.com.br", DateTime.Now));
            dbPessoas.Add(new EntidadePessoa("Rafael Aranha Viana", "rafael.aranha@csharp.com.br", DateTime.Now));
            dbPessoas.Add(new EntidadePessoa("Fernando Correa Ramalho", "fernando.correa@csharp.com.br", DateTime.Now));

            dbUsuarios = new List<EntidadeUsuario>();
            dbUsuarios.Add(new EntidadeUsuario("batman", "batman", "manager"));
            dbUsuarios.Add(new EntidadeUsuario("robin", "robin", "employee"));
        }

        public void AdicionarPessoa(EntidadePessoa pessoa)
        {
            dbPessoas.Add(pessoa);
        }

        public void AdicionarUsuario(EntidadeUsuario usuario)
        {
            dbUsuarios.Add(usuario);
        }
    }
}
