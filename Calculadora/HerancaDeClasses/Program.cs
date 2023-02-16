using HerancaDeClasses;

namespace Projetos
{

    class Program
    {
        static void Main(string[] args)
        {
            Cachorros cachorro1 = new Cachorros();
            cachorro1.Pelo = "Branco";
            cachorro1.Raça = "Poodle";
            cachorro1.Barulho = cachorro1.Som();
            cachorro1.Tipo = "Mamífero";
            cachorro1.Extincao = false;

            Console.WriteLine($"Um {cachorro1.Raça} {cachorro1.Pelo} que emite um {cachorro1.Barulho}.");


            Peixes peixe1 = new Peixes();
            peixe1.Tamanho = "45cm";
            peixe1.especie = "Linguado";
            peixe1.aguaSalgada = true;
            peixe1.Tipo = "Animal Aquático";
            peixe1.dieta = peixe1.Alimentacao();

            if (peixe1.aguaSalgada)
            {
                Console.WriteLine($"Um {peixe1.especie} de {peixe1.Tamanho} que habita em água salgada e se alimenta de {peixe1.dieta}.");
            }
            else
            {
                Console.WriteLine($"Um {peixe1.especie} de {peixe1.Tamanho} que habita em água doce e se alimenta de {peixe1.dieta}.");
            }
        }
    }
}
