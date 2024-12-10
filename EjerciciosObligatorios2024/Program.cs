using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class Cuenta
    {

        string titular;
        double cantidad; //cantidad actual

        public Cuenta(string Titular) 
        {
            this.titular = Titular;
            cantidad = 0;
        }

        public Cuenta(string Titular, double Cantidad) 
        {
            this.cantidad = Cantidad;
            this.titular = Titular;
        }

        public void Ingresar(double Cantidad) 
        {
            if (Cantidad > 0)
            {
                cantidad += Cantidad;
                Console.WriteLine("Cantidad: " + cantidad);
            }

        }

        public void Retirar(double Cantidad) //Cantidad enviada :v
        {
            if (Cantidad > cantidad)
            {
                cantidad = 0;
            }

            else 
            {
            cantidad -= Cantidad;
                Console.WriteLine("Cantidad: " + cantidad);
            }

        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta("Mateo", 400);
            Cuenta c2 = new Cuenta("ESTELA" );

            c1.Retirar(50);
            c1.Ingresar(500);

            c2.Retirar(50);
            c2.Ingresar(500);

            Console.ReadKey();
        }
    }
}
