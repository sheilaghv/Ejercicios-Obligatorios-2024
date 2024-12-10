using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class Productos
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Productos(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

       
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nombre: " + Nombre + " Precio: " + Precio+"$");
        }

        public virtual double Calcular(int cantidad) 
        {
         return Precio * cantidad;
        
        }
    }
}
