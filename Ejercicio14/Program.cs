using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Productos[] productos = new Productos[]
        {
            new Perecedero("Leche", 5, 1),      //  1 día para caducar
            new Perecedero("Pan", 8, 2),        //  2 días para caducar
            new NoPerecedero("Lata de Sopa", 2, "Alimentos en conserva"),
            new NoPerecedero("Televisor", 300, "Electrodoméstico")
        };
            foreach (Productos producto in productos)
            {
                producto.MostrarInfo();  // Mostrar la información del producto
                Console.WriteLine();


            }

            foreach (var product in productos)
            {
                double precioFinal = product.Calcular(5);
                Console.WriteLine(product.Nombre + " Precio total comprando 5: " + precioFinal + "$");

            }
            
            Console.ReadKey();
        }
    }
}
