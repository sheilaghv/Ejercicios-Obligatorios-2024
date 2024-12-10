using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class Juego
    {
        List<Jugador> Jugadores {  get; set; }
        Revolver Revolver { get; set; }

        public Juego(List<Jugador> jugadores)
        {
            this.Jugadores = jugadores;
            this.Revolver = new Revolver();
        }

        public bool FinJuego()
        {
            foreach (var jugador in Jugadores) 
            {
                if (!jugador.Vivo)
                { 
                    return true;
                }
            }
            return false;
        }

        public void Ronda() 
        {
            Console.WriteLine("Ronda: ");
            foreach (var jugador in Jugadores)
            {
                if (jugador.Vivo)
                {
                    Console.WriteLine("Turno de " + jugador.Nombre);
                    if (jugador.Disparar(Revolver))
                    {
                        Console.WriteLine(jugador.Nombre + " Murio");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine(jugador.Nombre + " Sigue vivo");
                    }
                    Revolver.SiguienteBala();
                }
            }
        }
    }
}
