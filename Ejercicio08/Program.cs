using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profesor profesor = new Profesor("Enrique", 34, 'M', "Matemáticas");
            Estudiantes[] estudiantes = new Estudiantes[]
                {
                 new Estudiantes("María", 18, 'F', 8),
                 new Estudiantes("Juan", 19, 'M', 6),
                 new Estudiantes("Ana", 20, 'F', 9),
                 new Estudiantes("Carlos", 21, 'M', 4),
                 new Estudiantes("Lucía", 22, 'F', 7),
                 new Estudiantes("Pedro", 19, 'M', 5),
                 new Estudiantes("Sofía", 20, 'F', 8),
                 new Estudiantes("Diego", 18, 'M', 6),
                 new Estudiantes("Marta", 21, 'F', 9),
                 new Estudiantes("Luis", 22, 'M', 3)    
                 };

            Aula aula = new Aula(6, 10, "Matemáticas", profesor, estudiantes);

            if (aula.PuedeDarClase())
            {
                int aprobadosM = 0;
                int aprobadosF = 0;
                Console.WriteLine("Se puede dar clase.");
                foreach (var estudiante in aula.Estudiantes)
                {
                    if (estudiante.EstaAprobado())
                    {
                        if (estudiante.Sexo == 'M')
                        {
                            aprobadosM++;
                        }
                        else if (estudiante.Sexo == 'F')
                        { 
                            aprobadosF++;                     
                        }                   
                    }
                }
                Console.WriteLine("Aprobados M: " + aprobadosM);
                Console.WriteLine("Aprobados F: " + aprobadosF);
            }
            else
            {
                Console.WriteLine("No se puede dar clase.");
            }

            
            Console.ReadKey();
        }
    }
}
//:,v
