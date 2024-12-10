using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Repartidor:Empleados
    {
        public string Zona { get; set; }

        
        public Repartidor(string nombre, int edad, double salario, string zona): base(nombre, edad, salario)
        {
            Zona = zona;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Zona: " + Zona);
        }

        public void Plus() 
        {
            if (Edad < 25 && Zona == "zona 3")
            {
                Salario += PLUS;
                Console.WriteLine("Salario actualizado: " + Salario);
            }
        
        }
    }
}
