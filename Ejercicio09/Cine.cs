using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    public class Cine
    {
        public Pelicula Pelicula { get; set; }
        public string NombPeli {  get; set; }
        public int PrecioEntrada { get; set; }
                    //matris          //para solo tener info
        public string[,] Sala { get; private set; }

        public Cine(string nombpeli, int precioentrada) 
        {
            this.NombPeli = nombpeli;
            this.PrecioEntrada = precioentrada;
            Sala = new string[8, 9];
        }

        public void GenerarAsientos()
        {
            for (int i = 0; i < Sala.GetLength(0); i++)  //recorrre las filas y
            {
                for (int j = 0; j < Sala.GetLength(1); j++) //recorre las columnas
                {
                    Sala[i, j] = $"{8 - i}{(char)('A' + j)}";
                }
            }


        }

        public bool SentarEspectador(Espectador espectador)
        {
            if (espectador.Edad < Pelicula.EdadMinima || espectador.Dinero < PrecioEntrada)
            {
                return false;
            }

            Random random = new Random();
            while (true)
            {
                int fila = random.Next(0, 8);
                int columna = random.Next(0, 9);

                if (Sala[fila, columna] != "X") // Si el asiento no está ocupado
                {
                    Sala[fila, columna] = "X";
                    return true;
                }
            }
        }


        public void MostrarSala()
        {
            for (int i = 0; i < Sala.GetLength(0); i++)
            {
                for (int j = 0; j < Sala.GetLength(1); j++)
                {
                    Console.Write(Sala[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
