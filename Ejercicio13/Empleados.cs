using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Empleados
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }
        public const double PLUS = 300;
        public Empleados(string nombre, int edad, double salario)
        {
            Nombre = nombre;
            Edad = edad;
            Salario = salario;
        }

        public virtual double CalcularSalario()
        {
            return Salario + PLUS;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nombre: " + Nombre + " Edad: " + Edad + " Salario: " + Salario);
        }
    }
}
