using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class Aula
    {
        public int ID { get; set; }
        public int NumMaxESTUDIANTES { get; set; }
        public string Materia { get; set; }
        public Profesor Profesor { get; set; }

        public Estudiantes[] Estudiantes { get; set; }


        public Aula(int id, int nummaxestudiantes, string materia, Profesor profesor, Estudiantes[] estudiantes) 
        {
            this.ID = id;
            this.NumMaxESTUDIANTES = nummaxestudiantes;
            this.Materia = materia; 
            this.Estudiantes = estudiantes;
            this.Profesor=profesor;
        }

        public bool PuedeDarClase()
        {
            int presentes = 0;
            foreach (var estudiante in Estudiantes)
            {
                Random rnd = new Random();
                if (rnd.Next(0, 100) >= 50) 
                {
                    presentes++;
                }
            }

            if (!Profesor.EstaDisponible())
            {
                return false;
            }
            if (Profesor.Materia != Materia)
            {
                return false;
            }
            if (presentes < (NumMaxESTUDIANTES / 2)) //si hay menos de la mitad del maximo de estudiantes
            {
                return false;
            }
                return true;
  
        }
    }

    
}
