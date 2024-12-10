using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class Baraja
    {
        private List<Carta> Cartas { get; set; } //aca elegis cualquier posicion
        private Stack<Carta> Monton { get; set; } //de aca elegis el primero
                      //array de 4 posiciones que solo se declara una vez, siempre esta ahi :3
        private static readonly string[] Palos = { "Espadas", "Bastos", "Oros", "Copas" };


        private void CrearBaraja()//creo el metodo
        {
            foreach (string palo in Palos)
            {  //inicio        //limite   //accion
                for (int i = 1; i <= 12; i++)  //genera una carta del 1 al 12
                {
                    if (i != 8 && i != 9) //despues deja de lado el 8 y el 9
                    {
                        Cartas.Add(new Carta(i, palo));
                        //
                    }
                }
            }
        }
        public Baraja()
        {
            Cartas = new List<Carta>();  //para que cuando la llamemos solo se muestre la baraja
            Monton = new Stack<Carta>();
            CrearBaraja();  // llamo al metodo
        }

       

        public void Barajar()
        {
            Random random = new Random();

            for (int i = 0; i < Cartas.Count; i++)//cuenta las cartas de la lista
            {
                int cartarandom = random.Next(Cartas.Count);//elige carta random de las cartas
                (Cartas[i], Cartas[cartarandom]) = (Cartas[cartarandom], Cartas[i]);
                //carta original se va al lugar de la carta random //carta random se va al lugar de la carta original
            }
        }

        public Carta SiguienteCarta() //crea un metodo para baraja usando la clase carta
        {                             //devuelve un objeto de la clase cartas
            if (Cartas.Count > 0)
            {
                Carta carta = Cartas[0]; //toma la primera carta
                Monton.Push(carta);  //mueve a carta al monto
                Cartas.RemoveAt(0);  //elimina la lista de cartas que quedan
                return carta; //y devuelve el numero y el palo de la carta
            }
            Console.WriteLine("No hay mas cartas");
            return null;  //si no hay mas cartas no devuelve nada
        }

        public void MostrarBaraja()
        {
            foreach (Carta carta in Cartas)
            {
                Console.WriteLine(carta);
            }
        }

        public void MostrarMonton()
        {
            if (Monton.Count != 0)
            {
                foreach (Carta carta in Monton)
                {
                    Console.WriteLine(carta);
                }
                
            }
            else
            {
                Console.WriteLine("No hay cartas");
            }
        }
    }
}
