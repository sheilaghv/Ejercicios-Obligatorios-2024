using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda(); 

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("--- MENÚ DE AGENDA TELEFÓNICA ---");
                Console.WriteLine("1. Añadir contacto");
                Console.WriteLine("2. Verificar si un contacto existe");
                Console.WriteLine("3. Listar de contactos");
                Console.WriteLine("4. Buscar un contacto ");
                Console.WriteLine("5. Eliminar un contacto");
                Console.WriteLine("6. Verificar si la agenda está llena");
                Console.WriteLine("7. Huecos libres");
              
                Console.Write("Selecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del contacto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Teléfono del contacto: ");
                        string telefono = Console.ReadLine();
                        agenda.AñadirContacto(new Contacto(nombre, telefono));
                        break;

                    case 2:
                        Console.Write("Nombre del contacto a verificar: ");
                        string nombreVerificar = Console.ReadLine();
                        if (agenda.ExisteContacto(new Contacto(nombreVerificar, "")))
                        {
                            Console.WriteLine("El contacto existe.");
                        }
                        else
                        {
                            Console.WriteLine("El contacto no existe.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Lista de contactos:");
                        agenda.ListarContactos();
                        break;

                    case 4:
                        Console.Write("Nombre del contacto : ");
                        string nombreBuscar = Console.ReadLine();
                        agenda.BuscarContacto(nombreBuscar);
                        break;

                    case 5:
                        Console.Write("Nombre del contacto a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        agenda.EliminarContacto(new Contacto(nombreEliminar, ""));
                        break;

                    case 6:
                        if (agenda.AgendaLlena())
                        {
                            Console.WriteLine("La agenda está llena");
                        }
                        else
                        {
                            Console.WriteLine("La agenda tiene espacio disponible");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Huecos libres: " + agenda.HuecosLibres());
                        break;

                   

                    default:
                        Console.WriteLine("Opción no válida, por favor intenta de nuevo.");
                        break;
                }

                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 0);
        }
    }
}
