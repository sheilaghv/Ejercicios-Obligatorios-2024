using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Apuesta
    {
        private List<Jugador> Jugadores { get; set; }
        private List<Partido> Partidos { get; set; }
        private int Pozo { get; set; }
        public Apuesta(int numJugadores, int dineroInicial, List<Partido> partidos)
        {
            Jugadores = new List<Jugador>
            {
                new Jugador("Ana", 100),
                new Jugador("Pedro", 100),
                new Jugador("Lucía", 100),
                new Jugador("Miguel", 100),
                new Jugador("Sofía", 100)
            };
            Partidos = partidos;
            Pozo = 0;
        }

        public void RealizarApuestas()
        {
            foreach (var jugador in Jugadores)
            {
                jugador.Apostar(1);
                Pozo++;
            }
        }
        public void SimularPartido()
        {
            RealizarApuestas();
            foreach (var partido in Partidos)
            {
                Console.WriteLine(partido.Resultado());
            }

            // Ganador aleatorio
            Random rand = new Random();
            var jugadorGanador = Jugadores[rand.Next(Jugadores.Count)];
            jugadorGanador.Ganar(Pozo);
            Console.WriteLine(jugadorGanador.Nombre + " ganó " + Pozo + "$");
        }
    }
}
