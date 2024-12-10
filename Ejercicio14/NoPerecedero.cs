using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class NoPerecedero : Productos
    {
        public string Tipo { get; set; }

        
        public NoPerecedero(string nombre, double precio, string tipo)
            : base(nombre, precio)
        {
            Tipo = tipo;
        }

      
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Tipo:"  + Tipo);
        }
        public override double Calcular(int cantidad)
        {
            return base.Calcular(cantidad);  // Solo multiplicar el precio por la cantidad
        }
    }
}
