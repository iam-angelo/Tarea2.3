using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            double tot;
            Console.WriteLine("Ingrese la cantidad a comprar");
            cant=int.Parse(Console.ReadLine());
            Console.Clear();
            if (cant <= 10)
            {
                tot = cant * 20;
                Console.WriteLine($"El precio seria $20 y el total es: {tot}");
            }
            else
            {
                tot = cant * 15;
                Console.WriteLine($"El precio seria $15 y el total es: {tot}");
            }
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
