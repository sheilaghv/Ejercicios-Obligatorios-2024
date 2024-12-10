using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Comercial : Empleados
    {
        public double Comision { get; set; }
        public Comercial(string nombre, int edad, double salario, double comision) : base(nombre, edad, salario)
        {
            Comision = comision;
        }
        public override double CalcularSalario()
        {
            return base.CalcularSalario() + Comision;
        }

        
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Comisión: " + Comision + "$");
        }

        public void Plus()
        {
            if (Edad > 30 && Comision > 200)
            {
                Salario += PLUS;
                Console.WriteLine("Salario actualizado: " + Salario);
            }

        }
    }
}
