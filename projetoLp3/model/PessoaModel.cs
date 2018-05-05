using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp3.model
{
    class PessoaModel
    {
        private String cpf;
        private String nome;
        private String celular;
        private String email;

        public PessoaModel()
        {
        }

        public PessoaModel(string cpf, string nome, string celular, string email)
        {
            Cpf = cpf;
            Nome = nome;
            Celular = celular;
            Email = email;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }

    }
}
