using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    class Baraja
    {
        private Cartas[] baraja;//Sea crea una clase Cartas
        private const int Num_de_Cartas = 52;//Indica el número de cartas en la baraja y nunca se altera
        private Random numAlt;//Número aleatorio
        private int cont=0;
        private int puntos;
        private List<object> manoOb = new List<object>(5);
        private ArrayList nuevaBaraja;
        private float Opción;
        public void Barajas()
        {
            string[] cara = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };//Se le asigna la cara a la carta
            string[] figura = { "♥", "♦", "♣", "♠" };//Se le asigan la figura a la carta
            numAlt = new Random();
            baraja = new Cartas[Num_de_Cartas];//Define el tamaño del arreglo
            for (int cont = 0; cont < Num_de_Cartas; cont++)
            {
                baraja[cont] = new Cartas(figura[cont / 13], cara[cont % 13]);//Se crea la baraja con la figura y la cara
            }
        }
        public void Barajear()
        { 
            for (int num1 = 0; num1<baraja.Length; num1++)//Método que altera el orden de la cartas
            {
                int num2 = numAlt.Next(Num_de_Cartas);//Variable que se la asigna un valor de la baraja
                Cartas temp = baraja[num1];//Variable para almacenar un valor temporal 
                baraja[num1] = baraja[num2];//Se guarda la variable a la posición actual
                baraja[num2] = temp;//El valor temporal se almacena en la variable 
            }
        }
        public void NuevaBaraja()
        {
            nuevaBaraja = new ArrayList(baraja);//Guarda la nueva baraja del arreglo en un ArrayList
            //foreach(var item in nuevaBaraja)
            //{
            //    cont++;
            //    Console.Write(item + " ");
            //    if (cont == 13)
            //    {
            //        Console.WriteLine();
            //        cont = 0;
            //    }
            //}
            //Este método solo fue utilizado para imprimir y comprobar si en realidad se alteró el orden y se guardó en el ArrayList
        }
        public void CartasEnMano()
        {
            do
            {
                Console.WriteLine("¿Desea quedarse con la carta " + nuevaBaraja[0] + "?");//Muestra la carta en la primera posición de la baraja
                Console.WriteLine("1 = sí");
                Opción = int.Parse(Console.ReadLine());
                if (Opción == 1)
                {
                    manoOb.Add(nuevaBaraja[0]);//Si el usuario acepta, se queda con la carta
                }
                nuevaBaraja.RemoveAt(0);//Se elimina la carta de la baraja
                nuevaBaraja.TrimToSize();//Se reacomoda el tamaño de la baraja
                cont++;
            } while(cont < 5);
            foreach(var item in manoOb)
            {
                Console.WriteLine(item);
            }
        }
    }
}
