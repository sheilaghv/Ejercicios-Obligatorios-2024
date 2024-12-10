using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Agenda
    {
        private List<Contacto> Contactos { get; set; }
        private int TamañoMaximo { get; set; }

        public Agenda(int tamañoMaximo = 10)
        {
            TamañoMaximo = tamañoMaximo;
            Contactos = new List<Contacto>();
        }


        public void AñadirContacto(Contacto c)  //objeto de tipo contacto
        {
            if (Contactos.Count < TamañoMaximo) //si la lista tiene menos q el limite
            {
                if (!Contactos.Contains(c))  //y no se repite
                {
                    Contactos.Add(c);
                    Console.WriteLine("Contacto: " + c.Nombre  + " añadido");
                }
                else
                {
                    Console.WriteLine("Contacto ya existe");
                }

            }
        }
        public bool ExisteContacto(Contacto c)
        {
            return Contactos.Contains(c);
        }

        public void ListarContactos()
        {
            if (Contactos.Count > 0)
            {
                foreach (var contacto in Contactos)
                {
                    Console.WriteLine("Nombre: " + contacto.Nombre + "Teléfono: " + contacto.Telefono);
                }
            }
            else
            {
                Console.WriteLine("No hay contactos");
            }
        }

        public void BuscarContacto(string nombre)
        {
            Contacto contacto = null;

            foreach (var c in Contactos)
            {
                if (c.Nombre == nombre)
                {
                    contacto = c;
                    break;
                }
            }

            if (contacto != null)
            {
                Console.WriteLine("Nombre: " + contacto.Nombre + " Teléfono: " + contacto.Telefono);
            }
            else
            {
                Console.WriteLine("Contacto no encontrado");
            }
        }

        public void EliminarContacto(Contacto c)
        {
            if (Contactos.Remove(c))
            {
                Console.WriteLine("Contacto "  + c.Nombre + " eliminado");
            }
            else
            {
                Console.WriteLine("Contacto no encontrado");
            }
        }

        public bool AgendaLlena()
        {
            return Contactos.Count >= TamañoMaximo;
        }

        public int HuecosLibres()
        {
            return TamañoMaximo - Contactos.Count;
        }
    }
}
