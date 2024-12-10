using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class Revolver
    {
        private int PosicionActual { get; set; }
        private int PosicionBala { get; set; }

        public Revolver()
        {
            Random rand = new Random();
            PosicionActual = rand.Next(1, 7);
            PosicionBala = rand.Next(1, 7);
        }
        public bool Disparar() 
        {
            return PosicionActual == PosicionBala;
        
        }

        public void SiguienteBala()
        {
            if (PosicionActual == 6) // Si la posición actual es la última
            {
                PosicionActual = 1; // Reinicia a la primera posición
            }
            else
            {
                PosicionActual++; // Avanza a la siguiente posición
            }
        }
        public override string ToString()
        {
            return "Posición actual: " + PosicionActual + "Posición bala: " + PosicionBala;
        }
    }
}
