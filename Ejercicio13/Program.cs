using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comercial comercial1 = new Comercial("Juan Pérez", 32, 1500, 250);
            Comercial comercial2 = new Comercial("Ana Gómez", 28, 1400, 180);

            Repartidor repartidor1 = new Repartidor("Carlos Díaz", 24, 1200, "zona 3");
            Repartidor repartidor2 = new Repartidor("Luis Martínez", 26, 1300, "zona 1");


            comercial1.MostrarInfo();
            comercial1.Plus();
            comercial2.MostrarInfo();
            comercial2.Plus();

            repartidor1.MostrarInfo();
            repartidor1.Plus();
            repartidor2.MostrarInfo();
            repartidor2.Plus();

            Console.ReadKey();
        }
    }
}
