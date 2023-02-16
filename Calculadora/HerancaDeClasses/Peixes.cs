
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDeClasses
{
    class Peixes : Animais
    {
        public string especie;
        public string dieta;
        public bool escamas;
        public bool aguaSalgada;

        public override string Andar()
        {
            return "Nadar";
        }

        public override string Alimentacao()
        {
            return "Planctons e algas";
        }

        public override string Som()
        {
            return "não emite";
        }
    }
}
