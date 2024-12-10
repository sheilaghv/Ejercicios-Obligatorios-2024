using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Serie[] series = new Serie[5];
                Videojuego[] videojuegos = new Videojuego[5];

                // Inicializar Series
                series[0] = new Serie("Breaking Bad", 5, "Drama", "Vince Gilligan");
                series[1] = new Serie("Stranger Things", 4, "Ciencia Ficción", "Hermanos Duffer");
                series[2] = new Serie("Game of Thrones", 8, "Fantasía", "David Benioff y D.B. Weiss");
                series[3] = new Serie("The Office", 9, "Comedia", "Greg Daniels");
                series[4] = new Serie("The Crown", 6, "Histórica", "Peter Morgan");

                // Inicializar Videojuegos
                videojuegos[0] = new Videojuego("The Last of Us", 30, "Aventura", "Naughty Dog");
                videojuegos[1] = new Videojuego("God of War", 20, "Acción", "Santa Monica Studio");
                videojuegos[2] = new Videojuego("Red Dead Redemption 2", 50, "Mundo Abierto", "Rockstar Games");
                videojuegos[3] = new Videojuego("Minecraft", 100, "Creatividad", "Mojang");
                videojuegos[4] = new Videojuego("FIFA 23", 15, "Deportes", "EA Sports");

            series[0].entregar();

            videojuegos[4].entregar();

            int seriesEntregadas=0;
            int videojuegosEntregados = 0;

            foreach (var videojuego in videojuegos)
            {
                if (videojuego.isEntregado())
                { 
                    videojuegosEntregados++; 
                }
            }

            foreach (var serie in series)
            {
                if (serie.isEntregado())
                {
                    seriesEntregadas++;
                }


            }
            Console.WriteLine($"Series entregadas: {seriesEntregadas}");
            Console.WriteLine($"Videojuegos entregados: {videojuegosEntregados}");

            Console.ReadKey();
        }
    }
}
