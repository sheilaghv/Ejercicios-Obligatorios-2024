using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Partido> partidos = new List<Partido>
            {
                new Partido(" River ", " Huracan "),
                new Partido(" Boca Juniors ", " San Lorenzo ")
            };

            Apuesta apuesta = new Apuesta(5, 8, partidos);
            apuesta.SimularPartido();

            Console.ReadKey();
        }
    }
}
