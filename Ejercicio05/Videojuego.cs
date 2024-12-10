using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Videojuego : Entregable
    {
        public string titulo { get; set; }
        public int horasEst { get; set; }
        public bool entregado { get; set; }
        public string genero { get; set; }
        public string compañia { get; set; }

        public Videojuego() 
        {
            titulo = "-";
            horasEst = 10;
            entregado = false;
            genero = "-";
            compañia = "-";
        }

        public Videojuego(string Titulo, int HorasEST)
        { 
            this.titulo = Titulo;
            this.horasEst = HorasEST;
            entregado = false;
            genero = "-";
            compañia = "-";
        }

        public Videojuego(string Titulo, int HorasEst,  string Genero, string Compañia) 
        {
            this.titulo= Titulo;
            this.horasEst= HorasEst;
            this.genero = genero;
            this.compañia = compañia;
            entregado = false;
        }

        public void entregar()
        {
            entregado = true;
        }

        public void devolver()
        {
            entregado = false;
        }

        public bool isEntregado()
        {
            return entregado;
        }
    }
}
