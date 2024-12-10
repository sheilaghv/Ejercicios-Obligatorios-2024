using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    public enum PalosBarEspañola
    {
        OROS,
        COPAS,
        ESPADAS,
        BASTOS
    }

    public enum PalosBarFrancesa
    {
        DIAMANTES,
        PICAS,
        CORAZONES,
        TREBOLES
    }

    public abstract class Baraja
    {
        public int NumeroCartas { get; set; }
        public int CartasPorPalo { get; set; }
        public abstract void CrearBaraja();
    }

    public class Carta<Tipos>
    {
        public int Numero { get; set; }
        public Tipos Palo { get; set; }

        public Carta(int numero, Tipos palo)
        {
            Numero = numero;
            Palo = palo;
        }

        public override string ToString()
        {
            return "Carta: "+ Numero +" de " + Palo ;
        }
    }

    public class BarajaEspañola : Baraja
    {
        public bool IncluirOchoYNueve { get; set; }
        public List<Carta<PalosBarEspañola>> Cartas { get; set; }

        public BarajaEspañola(bool incluirOchoYNueve = true)
        {
            IncluirOchoYNueve = incluirOchoYNueve;
            Cartas = new List<Carta<PalosBarEspañola>>();
            CrearBaraja();
        }

        public override void CrearBaraja()
        {
            int cartasPorPalo;
            if (IncluirOchoYNueve)
            {
                cartasPorPalo = 12;
            }
            else
            {
                cartasPorPalo = 10;
            }

            foreach (PalosBarEspañola palo in Enum.GetValues(typeof(PalosBarEspañola)))
            {
                for (int i = 1; i <= cartasPorPalo; i++)
                {
                    Cartas.Add(new Carta<PalosBarEspañola>(i, palo));
                }
            }
        }
    }

    public class BarajaFrancesa : Baraja
    {
        public List<Carta<PalosBarFrancesa>> Cartas { get; set; }

        public BarajaFrancesa()
        {
            Cartas = new List<Carta<PalosBarFrancesa>>();
            CrearBaraja();
        }

        public override void CrearBaraja()
        {
            foreach (PalosBarFrancesa palo in Enum.GetValues(typeof(PalosBarFrancesa)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    Cartas.Add(new Carta<PalosBarFrancesa>(i, palo));
                }
            }
        }

        public void CartaRoja(Carta<PalosBarFrancesa> carta)
        {
            if (carta.Palo.Equals(PalosBarFrancesa.CORAZONES) || carta.Palo.Equals(PalosBarFrancesa.DIAMANTES))
            {
                Console.WriteLine("Es una carta roja");
            }
        }

        public void CartaNegra(Carta<PalosBarFrancesa> carta)
        {
            if (carta.Palo.Equals(PalosBarFrancesa.TREBOLES) || carta.Palo.Equals(PalosBarFrancesa.PICAS))
            {
                Console.WriteLine("Es una carta negra");
            }
        }
    }
}