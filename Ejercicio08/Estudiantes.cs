using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class Estudiantes
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public int Califacion { get; set; }

        public Estudiantes(string nombre, int edad, char sexo, int calificacion) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Califacion = calificacion;
        
        }

        public bool EstaAprobado()
        {
            return Califacion >= 5;
        }
    }
}
