using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpressaoDeDados
{
    class Construtores
    {
        public string Nome;
        public string Email;
        public string Profissao;
        public string Cidade;
        public int Idade;
        public double Salario;

        public Construtores(string nome, string email, string profissao, string cidade, int idade, double salario)
        {
            Nome = nome;
            Email = email;
            Profissao = profissao;
            Cidade = cidade;
            Salario = salario;
        }

        public Construtores()
        {

        }
    }
}
