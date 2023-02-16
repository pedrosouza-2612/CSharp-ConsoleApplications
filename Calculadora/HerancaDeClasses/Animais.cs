using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDeClasses
{
    abstract class Animais
    {
        public string Tipo;
        public bool Extincao;
        public string Tamanho;

        public abstract string Andar();
        public abstract string Alimentacao();
        public abstract string Som();

    }
}
