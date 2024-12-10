using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Producto
    {
        public int Id { get; set; }
        public double Litros { get; set; }
        public double Precio { get; set; }
        public string Marca { get; set; }

        public Producto(int id, double litros, double precio, string marca)
        {
            Id = id;
            Litros = litros;
            Precio = precio;
            Marca = marca;
        }

        public virtual double CalcularPrecio()
        {
            return Precio;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine("ID: " + Id + " Marca: " + Marca + " Litros:" + Litros +" Precio: " + Precio +"$");
        } 
    }
}
