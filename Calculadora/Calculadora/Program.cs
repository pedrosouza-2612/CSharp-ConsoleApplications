namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacao, confirma = "sim";
            int x, y;

            Console.Write("Digite um número: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            y = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Digite a operação que deseja: Soma, Subtração, Divisão, Multiplicação: ");
                operacao = Console.ReadLine();

                while ((operacao != "Soma") && (operacao != "Subtração") && (operacao != "Divisão") && (operacao != "Multiplicação"))
                {
                    Console.Write("Digite uma opção válida: ");
                    operacao = Console.ReadLine();
                }

                if (operacao == "Soma")
                {
                    Console.WriteLine("A soma dos valores é: " + Operacoes.Soma(x, y));
                }
                else if (operacao == "Subtração")
                {
                    Console.WriteLine("A subtração dos valores é: " + Operacoes.Subtrair(x, y));
                }
                else if (operacao == "Divisão")
                {
                    Console.WriteLine("A divisão dos valores é: " + Operacoes.Dividir(x, y));
                }
                else if (operacao == "Multiplicação")
                {
                    Console.WriteLine("A multiplicação dos valores é: " + Operacoes.Multiplicar(x, y));
                }

                Console.Write("Deseja realizar outra operação? ");
                confirma = Console.ReadLine();
            } while (confirma == "sim");
        }
    }
}
