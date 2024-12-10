
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Contacto(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        public override bool Equals(object obj)
        {
            if (obj is Contacto contacto)
                return Nombre == contacto.Nombre;
            return false;
        }
        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
    }
}
