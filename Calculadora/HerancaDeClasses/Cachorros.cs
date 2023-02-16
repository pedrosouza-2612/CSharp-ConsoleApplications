using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDeClasses
{
    class Cachorros : Animais
    {
        public string Raça;
        public string Pelo;
        public string Barulho;

        public override string Andar()
        {
            return "Quadrúpede";
        }

        public override string Alimentacao()
        {
            return "Onívoro";
        }

        public override string Som()
        {
            return "Latido";
        }
    }
}
