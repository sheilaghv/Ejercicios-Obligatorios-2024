using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baraja baraja = new Baraja();
            baraja.Barajar();

            Console.WriteLine("Monto:");
            baraja.MostrarMonton();

            Console.WriteLine("Cartas mezcladas:");
            baraja.MostrarBaraja();

            Console.WriteLine("Siguiente carta:");
            Console.WriteLine(baraja.SiguienteCarta());

           Console.ReadKey();
        }
    }
}
