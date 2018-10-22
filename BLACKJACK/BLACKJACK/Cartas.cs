using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    class Cartas
    {
        private string cara;//Para los números y letras
        private string figura;//Para los símbolos
        public Cartas(string cartaCara, string cartaFigura)
        {
            cara = cartaCara;
            figura = cartaFigura;
        }
        public override string ToString()
        {
            return cara + figura;
        }
    }
}
