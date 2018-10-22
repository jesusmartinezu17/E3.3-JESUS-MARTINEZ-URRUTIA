using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS
{
    public class Operaciones
    {
        public void Principal()
        {
            Console.WriteLine("Ingrese la cantidad de Carros");
            int cantidad = int.Parse(Console.ReadLine());
            Auto carro;
            List<Auto> carros = new List<Auto>();
            for (int i = 0; i < cantidad; i++)
            {
                carro = new Auto();
                carro.Id = i + 1;
                Console.WriteLine("Asigne una marca");
                carro.Marca = Console.ReadLine();
                Console.WriteLine("Asigne un modelo");
                carro.Modelo = Console.ReadLine();
                Console.WriteLine("Asigne un año");
                carro.Año = Console.ReadLine();
                Console.WriteLine("Asigne un color");
                carro.Color = Console.ReadLine();
                Console.WriteLine("Asigne placas");
                carro.PLacas = Console.ReadLine();
                Console.WriteLine();
            }
            Console.ReadKey();
            foreach(var item in carros)
            {
                Console.WriteLine(item.Marca + " " + item.Modelo + " " + item.PLacas);
            }
            var carroAzules = (from c in carros where c.Color == "azul" select c).ToList();
            foreach (var item in carroAzules)
            {
                //Mostramos los datos del carro
                Console.WriteLine(item.Modelo + " " + item.PLacas + " " + item.Color);
            }
        }
    }
}
