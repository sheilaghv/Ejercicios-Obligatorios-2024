using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Almacen almacen = new Almacen(3, 3);

            // Crear algunos productos
            BebidaConAzucar cocaCola = new BebidaConAzucar(1, 2, 1.5, "Coca-Cola", 10, true);
            AguaMineral agua = new AguaMineral(2, 1, 1.0, "Aquafina", "Manantial El Carmen");

            // Almacenar productos
            almacen.AlmacenarProducto(cocaCola);
            almacen.AlmacenarProducto(agua);

            // Mostrar información
            almacen.MostrarInformacion();

            // Calcular precios
            Console.WriteLine("Precio total del almacén:" + almacen.CalcularPrecioTotal());
            Console.WriteLine("Precio total de bebidas de marca " + "Coca-Cola" + almacen.CalcularPrecioMarca("Coca-Cola"));
            Console.WriteLine("Precio total de la estantería 0: " + almacen.CalcularPrecioEstanteria(0));

           
            almacen.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
