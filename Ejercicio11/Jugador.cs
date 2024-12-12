using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Jugador
    {
        public string Nombre { get; set; }  //se puede leer y modificar desde cualquier lugar
        public int Dinero { get; private set; } //se puede leer en cualquier lugar, pero dlo se va a nodifcon la logica de esta clase
        public int Victorias { get; private set; }

        public Jugador(string nombre, int dineroInicial)
        {
            Nombre = nombre;
            Dinero = dineroInicial;
            Victorias = 0;
        }

        public void Apostar(int cantidadapostada)
        {
            if (Dinero >= cantidadapostada)
            {
                Dinero -= cantidadapostada;
            }
            else
            {
                Console.WriteLine("Dinero insuficiente");
            }
        }

        public void Ganar(int pozo)
        {
            Dinero += pozo;
            Victorias++;
        }
    }
}
