using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class AguaMineral:Producto
    {
        public string Origen { get; set; }

        public AguaMineral(int id, double litros, double precio, string marca, string origen)    : base(id, litros, precio, marca)
        {
            Origen = origen;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Origen: " + Origen);
        }
    }
}
