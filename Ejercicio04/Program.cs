using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] electrodomest = new Electrodomestico[10];

            electrodomest[0] = new Electrodomestico(200, "Negro", 'A', 10);
            electrodomest[1] = new Lavadora(300, "Rojo", 'B', 40, 35);
            electrodomest[2] = new Television(400, "Blanco", 'C', 10, 50, true);
            electrodomest[3] = new Television(150, "Gris", 'D', 8, 32, false);
            electrodomest[4] = new Lavadora(350, "Blanco", 'E', 55, 20);
            electrodomest[5] = new Electrodomestico(100, 15);
            electrodomest[6] = new Television(500, "Gris", 'A', 20, 60, true);
            electrodomest[7] = new Lavadora(250, 35);
            electrodomest[8] = new Electrodomestico(); //por defecto
            electrodomest[9] = new Lavadora();  //por defecto

            double totalElectrodomesticos = 0, totalLavadoras = 0, totalTelevisores = 0;

            foreach (var electro in electrodomest)
            {
                double precio = electro.PrecioFinal();
                totalElectrodomesticos += precio;

                if (electro is Lavadora lavadora) //si es lavadora
                {
                    totalLavadoras += precio;  //aumenta en lavadoras
                }
                else if (electro is Television televisor)
                {
                    totalTelevisores += precio;
                }
            }

            Console.WriteLine("Precio Electrodomésticos: " + totalElectrodomesticos);
            Console.WriteLine("Precio Lavadoras: " + totalLavadoras);
            Console.WriteLine("Precio Tele:" + totalTelevisores);

            Console.ReadKey();
        }
    }
}
