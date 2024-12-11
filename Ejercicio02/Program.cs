using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{

    internal class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce la edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el sexo (H/M): ");
            char sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura (m): ");
            double altura = double.Parse(Console.ReadLine());


            Persona p1 = new Persona(nombre, edad, sexo, peso, altura);
            Persona p2 = new Persona(nombre, edad, sexo);
            Persona p3 = new Persona();
            p3.setNombre("Default");
            p3.setEdad(30);
            p3.setSexo('M');
            p3.setPeso(70);
            p3.setAltura(1.75);

          
            Persona[] personas = { p1, p2, p3 };
            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.ToString());
                Console.WriteLine("Mayor de edad: " + persona.esMayorDeEdad());
                Console.WriteLine("IMC:" + persona.calcularIMC());
                Console.WriteLine();
            }
            Console.ReadKey();
        }

       

    } 
}
