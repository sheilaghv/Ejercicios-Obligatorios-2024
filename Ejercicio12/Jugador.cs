using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Vivo { get; set; }

        public Jugador(int id)
        {
            Id = id;
            Nombre = "Jugador " + id;
            Vivo = true;
        }

        public bool Disparar(Revolver r)
        {
            if (r.Disparar())
            { 
                Vivo=false;
                return true; //muestra que la bala acerto
            
            }
            return false;  //si no acierta, la bala falla
        
        }
    }
}
