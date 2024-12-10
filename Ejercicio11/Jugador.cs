using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Dinero { get; private set; }
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
