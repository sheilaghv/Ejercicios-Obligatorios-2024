using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Electrodomestico
    {
        protected double precioBase { get; set; }  //para que se puedan usar los atributos de la clase mama :v
        protected string color { get; set; }  //obtener y establecer el valor del atributo
        protected char consumoEnergetico { get; set; }
        protected double peso { get; set; }

        private const double PRECIOBASE = 100;
        private const string COLORDEFECTO = "Blanco";
        private const char CONSUMODEFECTO = 'F';
        private const double PESODEFECTO = 5;

        public Electrodomestico() //defecto
        { 
            precioBase = PRECIOBASE;
            color = COLORDEFECTO;   
            consumoEnergetico = CONSUMODEFECTO;
            peso = PESODEFECTO;
        }

        public Electrodomestico(double Preciobase, double Peso) //donde el precio y el peso los ponen desde el program
        {
            precioBase= Preciobase;
            color = COLORDEFECTO;
            consumoEnergetico= CONSUMODEFECTO;
            peso = Peso;
        
        }
        
         
            private string ComprobarColor(string color)
            {
                string[] coloresValidos = { "Blanco", "Negro", "Rojo", "Azul", "Gris" };

                foreach (string colorValido in coloresValidos)
                {                             //compara el string y ignora las mayusculas y minusculas
                    if (color.Equals(colorValido, StringComparison.OrdinalIgnoreCase)) //compara el color que ingresa el usuario con alguno del array
                    {
                        return color; // y si es igual muestra el color
                }
                }

                return COLORDEFECTO; // Si no se encuentra, devuelve el color por defecto
            }

            private char ComprobarConsumoEnergetico(char letra)
            {
                if (letra == 'A' || letra == 'B' || letra == 'C' || letra == 'D' || letra == 'E' || letra == 'F')
                {
                    return letra; // Si la letra es válida, la devuelve
                }
                else
                {
                    return CONSUMODEFECTO; // Si no es válida, devuelve el valor por defecto
                }
            }
        
 
        public Electrodomestico(double Preciobase, string Color, char Consumoenergetico, double Peso) 
        {
            precioBase = Preciobase;
            color = ComprobarColor(Color);
            consumoEnergetico = ComprobarConsumoEnergetico(consumoEnergetico);
            peso = Peso;
        }

        public virtual double PrecioFinal()
        {

            double incremento = 0;

            if (consumoEnergetico == 'A')
            {
                incremento = 100;
            }
            else if (consumoEnergetico == 'B')
            {
                incremento = 80;
            }
            else if (consumoEnergetico == 'C')
            {
                incremento = 60;
            }

            else if (consumoEnergetico == 'D')
            {
                incremento = 50;
            }

            else if (consumoEnergetico == 'E')
            {
                incremento = 30;
            }

            else
            {
                incremento = 10;
            }


            if (peso >= 0 && peso < 20)
            {
                incremento += 10;
            }
            else if (peso >= 20 && peso < 50)
            {
                incremento += 50;
            }

            else if (peso >= 50 && peso < 80)
            {
                incremento += 80;
            }
            else
            { 
                incremento += 100;
            }

               return precioBase + incremento;
        }


    }
    public class Television : Electrodomestico
    {
        private int Resolucion { get; set; }
        private bool SintonizadorTDT { get; set; }

        private const int resolucionpordefecto = 20;
        private const bool sintonizadorpordefecto = false;

        public Television() : base()
        {
            Resolucion = resolucionpordefecto;
            SintonizadorTDT = sintonizadorpordefecto;
        }

        public Television(double precioBase, double peso) : base(precioBase, peso)
        {
            Resolucion = resolucionpordefecto;
            SintonizadorTDT = sintonizadorpordefecto;
        }

        public Television(double precioBase, string color, char consumoEnergetico, double peso, int resolucion, bool sintonizadorTDT)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            Resolucion = resolucion;
            SintonizadorTDT = sintonizadorTDT;
        }

        public override double PrecioFinal()
        {
            double precio = base.PrecioFinal();
            if (Resolucion > 40)
            {
                precio += precioBase * 0.3; //aumenta un 30%
            }
            if (SintonizadorTDT)
            {
                precio += 50;
            }
            return precio;
        }
    }

    public class Lavadora : Electrodomestico
    {
        private double Carga { get; set; }

        private const double cargapordefecto = 5;

        public Lavadora() : base()
        {
            Carga = cargapordefecto;
        }

        public Lavadora(double precioBase, double peso) : base(precioBase, peso)
        {
            Carga = cargapordefecto;
        }

        public Lavadora(double precioBase, string color, char consumoEnergetico, double peso, double carga)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            Carga = carga;
        }

        public override double PrecioFinal()
        {
            double precio = base.PrecioFinal();
            if (Carga > 30)
            {
                precio += 50;
            }
            return precio;
        }
    }
}
