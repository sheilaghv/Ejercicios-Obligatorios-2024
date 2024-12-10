using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelicula pelicula = new Pelicula("Inception", 148, 13, "Christopher Nolan");
            Cine cine = new Cine(pelicula.Titulo, 650);

            cine.GenerarAsientos();
            Console.WriteLine("Sala:");
            cine.MostrarSala();

           

            Espectador[] espectadores = new Espectador[10];
           
            espectadores[0] = new Espectador("Juan", 25, 15);
            espectadores[1] = new Espectador("Maria", 22, 10);
            espectadores[2] = new Espectador("Pedro", 30, 5);
            espectadores[3] = new Espectador("Lucia", 28, 12);
            espectadores[4] = new Espectador("Carlos", 18, 8);
            espectadores[5] = new Espectador("Ana", 24, 20);
            espectadores[6] = new Espectador("Miguel", 26, 10);
            espectadores[7] = new Espectador("Isabel", 23, 15);
            espectadores[8] = new Espectador("Oscar", 27, 5);
            espectadores[9] = new Espectador("Sofia", 21, 18);


            foreach (var espectador in espectadores)
            {
                if (cine.SentarEspectador(espectador))
                {
                    Console.WriteLine($"{espectador.Nombre} se sentó.");
                }
                else
                {
                    Console.WriteLine($"{espectador.Nombre} no pudo sentarse.");
                }
            }

            Console.WriteLine("Sala: ");
            cine.MostrarSala();

            Console.ReadKey();
        }
    }
}
