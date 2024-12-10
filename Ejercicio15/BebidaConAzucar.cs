using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class BebidaConAzucar : Producto
    {
        public double PorcentajeAzucar { get; set; }
        public bool TienePromocion { get; set; }

        public BebidaConAzucar(int id, double litros, double precio, string marca, double porcentajeAzucar, bool tienePromocion)  : base(id, litros, precio, marca)
        {
            PorcentajeAzucar = porcentajeAzucar;
            TienePromocion = tienePromocion;
        }

        public override double CalcularPrecio()
        {
            double precioFinal = Precio;
            if (TienePromocion)
            {
                precioFinal *= 0.9; // descuento del 10%
            }
            return precioFinal;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Porcentaje de azúcar: " + PorcentajeAzucar +"%"+ " Promocion: " + TienePromocion );
        }
    }
}
