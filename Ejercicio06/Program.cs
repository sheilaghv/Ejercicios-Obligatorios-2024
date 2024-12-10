using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libros libro1= new Libros(978, "BLABLA", "Gabriel", 417);
            Libros libro2 = new Libros(97856, "1984", "George ", 8);

            if (libro1.NumPaginas > libro2.NumPaginas)
            {
                Console.WriteLine("El libro " + libro1.Titulo + "tiene mas paginas");

            }

            else 
            {
                Console.WriteLine("El libro " + libro2.Titulo + "tiene mas paginas");
            }
            Console.ReadKey();
        }
    }
}
