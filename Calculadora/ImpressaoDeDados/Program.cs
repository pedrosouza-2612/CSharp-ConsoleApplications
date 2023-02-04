using ImpressaoDeDados;

namespace Projetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando manualmente
            Construtores pessoa1 = new Construtores();
            pessoa1.Nome = "Pedro Souza";
            pessoa1.Email = "phenriquegss@gmail.com";
            pessoa1.Profissao = "Desenvolvedor .NET";
            pessoa1.Cidade = "Cajamar";
            pessoa1.Idade = 20;
            pessoa1.Salario = 1700.00;

            Console.WriteLine($"Meu nome é {pessoa1.Nome} e eu sou um objeto de parâmetros padrão!");
            Console.WriteLine("O que significa que meus valores são pré determinados no código e assumirei esses valores durante a execução do programa!");
            Console.WriteLine($"Para entrar em contato comigo me mande pelo email: {pessoa1.Email}");
            Console.WriteLine($"sou {pessoa1.Profissao} e moro em {pessoa1.Cidade}");
            Console.WriteLine($"Tenho {pessoa1.Idade} anos e meu salário atual é {pessoa1.Salario.ToString("C")}");
            Console.WriteLine('\n');
           

            //Instanciando pelo construtor
            string nome, email, profissao, cidade;
            int idade;
            double salario;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu email: ");
            email = Console.ReadLine();
            Console.Write("Digite sua profissão: ");
            profissao = Console.ReadLine();
            Console.Write("Digite sua cidade atual: ");
            cidade = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite seu salário atual: R$");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine('\n');

            Construtores pessoa2 = new Construtores(nome, email, profissao, cidade, idade, salario);
            Console.WriteLine($"Meu nome é {pessoa2.Nome} e sou um objeto com parâmetros variáveis!");
            Console.WriteLine("O que significa que ao executar o programa novamente, meus valores podem ser alterados pelo usuário!");
            Console.WriteLine($"para entrar em contato comigo me mande pelo email: {pessoa2.Email}");
            Console.WriteLine($"sou {pessoa2.Profissao} e moro em {pessoa2.Cidade}");
            Console.WriteLine($"Tenho {pessoa2.Idade} anos e meu salário atual é {pessoa2.Salario.ToString("C")}");
        }
    }
}