using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices e1 = new Raices(1, 3, 4);
            Raices e2 = new Raices(1, 1, 1);
            Raices e3 = new Raices(1, 3, 5);

            Console.WriteLine("Ecuación 1:");
            e1.Calcular();

            Console.WriteLine("Ecuación 2:");
            e2.Calcular();

            Console.WriteLine("Ecuación 3:");
            e3.Calcular();

            Console.ReadKey();
        }
    }
}
