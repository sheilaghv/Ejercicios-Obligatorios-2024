using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    public class Raices
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Raices(double A, double B, double C)
        {
            this.a = A;
            this.b = B;
            this.c = C;

        }

        public double getDiscriminante()
        {
            return (b * b) - (4 * a * c);

        }

        public bool TieneRaices()
        {
            return getDiscriminante() > 0;
        }

        public bool TieneRaiz()
        {
            return getDiscriminante() == 0;
        }

        public void ObtenerRaices()
        {
            if (TieneRaices())
            {
                double r1 = (-b + Math.Sqrt(getDiscriminante())) / (2 * a);
                double r2 = (-b - Math.Sqrt(getDiscriminante())) / (2 * a);
                Console.WriteLine("Soluciones: " + r1 + " y " + r2);
            }

        }

        public void ObtenerRaiz()
        {
            if (TieneRaiz())
            {
                double raiz = -b / (2 * a);
                Console.WriteLine("Solucion: " + raiz);
            }
        }
        public void Calcular()
        {
            if (TieneRaices())
            {
                ObtenerRaices();
            }
            else if (TieneRaiz())
            {
                ObtenerRaiz();
            }
        }
    }
}
