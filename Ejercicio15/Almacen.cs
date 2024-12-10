using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Almacen
    {
        public Producto[,] Estanterias { get; set; }

        public Almacen(int filas, int columnas)
        {
            Estanterias = new Producto[filas, columnas];
        }

        public void AlmacenarProducto(Producto producto)
        {

            bool almacenado = false;

            // Verifica si el producto ya existe
            foreach (var item in Estanterias)
            {
                if (item != null && item.Id == producto.Id)  // Asegúrate de que 'item' no sea null
                {
                    Console.WriteLine("Ya existe.");
                    return;
                }
            }
            for (int i = 0; i < Estanterias.GetLength(0); i++)
            {
                for (int j = 0; j < Estanterias.GetLength(1); j++)
                {
                    if (Estanterias[i, j] == null)  // Si encontramos una posición vacía
                    {
                        Estanterias[i, j] = producto;  // Almacenamos el producto aca
                        Console.WriteLine(" Producto: " + producto.Marca + " almacenado en la posición " + i + " , " + j);
                        almacenado = true;
                        break;
                    }
                }
                if (almacenado) break;
            }

            // Si no encontramos espacio libre
            if (!almacenado)
            {
                Console.WriteLine("No hay espacio disponible ");
            }
  
        }
        public double CalcularPrecioTotal()
        {
            double precioTotal = 0;
            foreach (var producto in Estanterias)
            {
                if (producto != null)
                {
                    precioTotal += producto.CalcularPrecio();
                }
            }
            return precioTotal;
        }

        public double CalcularPrecioMarca(string marca)
        {
            double precioTotal = 0;
            foreach (var producto in Estanterias)
            {
                if (producto != null && producto.Marca == marca)
                {
                    precioTotal += producto.CalcularPrecio();
                }
            }
            return precioTotal;
        }

        public double CalcularPrecioEstanteria(int columna)
        {
            double precioTotal = 0;
            for (int i = 0; i < Estanterias.GetLength(0); i++)
            {
                var producto = Estanterias[i, columna];
                if (producto != null)
                {
                    precioTotal += producto.CalcularPrecio();
                }
            }
            return precioTotal;
        }

        public void MostrarInformacion()
        {
            foreach (var producto in Estanterias)
            {
                if (producto != null)
                {
                    producto.MostrarInformacion();
                    Console.WriteLine("----------------------------");
                }
            }
        }
    }
}
