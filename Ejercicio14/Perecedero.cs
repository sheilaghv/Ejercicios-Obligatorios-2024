using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Perecedero : Productos
    {
        public int DiasACaducar { get; set; }

       
        public Perecedero(string nombre, double precio, int diasACaducar) : base(nombre, precio)
        {
            DiasACaducar = diasACaducar;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Días a caducar: " + DiasACaducar);
        }

        public override double Calcular(int cantidad)
        {
            double precioFinal = base.Calcular(cantidad); // multiplica el precio del producto con la cantidad para saber su precio final

          
            if (DiasACaducar == 1)
                precioFinal *= 0.25;  // Se reduce 4 veces el precio
            else if (DiasACaducar == 2)
                precioFinal *= 0.33;  // Se reduce 3 veces el precio
            else if (DiasACaducar == 3)
                precioFinal *= 0.5;   // Se reduce a la mitad del precio

            return  precioFinal;
        }
    }
}
