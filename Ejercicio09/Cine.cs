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
                     int fila = 8 - i; // resta 8 con la posicion de cada fila ; 8-0= 8... 
                     char columna = (char)('A' + j); // le suma a A cada posicion de la columna A + 0 = A... A + (posicion)1 = B
                     Sala[i, j] = fila.ToString() + columna; // las combina y las escribe
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
            while (true)  //mientras que bool sentarespectador sea verdadero va c cumplir lo siguiente 
            {
                int fila = random.Next(0, 8);
                int columna = random.Next(0, 9);

                if (Sala[fila, columna] != "X") // Si el asiento no está ocupado
                {
                    Sala[fila, columna] = "X"; //si no hay x, se puede sentar y ahora se pone la x en esa posicion
                    return true;
                }
            }
        }


        public void MostrarSala()
        {
            for (int i = 0; i < Sala.GetLength(0); i++)  //recorre fila
            {
                for (int j = 0; j < Sala.GetLength(1); j++) //recorre columnas
                {
                    Console.Write(Sala[i, j] + " "); //dibuja
                }
                Console.WriteLine();
            }
        }

    }
}
