using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;//Permite imprimir carácteres especiales
            Baraja baj = new Baraja();// Se inicia la clase
            baj.Barajas();//Se crea la baraja
            baj.Barajear();//Se altera el orden de la baraja
            baj.NuevaBaraja();//Se crea una nueva baraja con el orden alterado
            baj.CartasEnMano();//El usuario elige las cartas para su mano
            Console.ReadKey();
        }
    }
}
