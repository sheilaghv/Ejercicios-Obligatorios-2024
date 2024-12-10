using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class Carta
    {
        public int Numero { get; set; }
        public string Palo { get; set; }

        public Carta(int numero, string palo)
        {
            Numero = numero;
            Palo = palo;
        }

        public override string ToString()
        {
            return $"{Numero} de {Palo}";
        }
    }
}
