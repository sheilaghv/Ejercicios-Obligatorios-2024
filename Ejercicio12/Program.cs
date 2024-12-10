using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>
        {
            new Jugador(1),
            new Jugador(6),
            new Jugador(4),
            new Jugador(3),
            new Jugador(2)
        };

           
            Juego juego = new Juego(jugadores);

            juego.Ronda();

            Console.ReadKey();
        }
    }
}
