using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Serie : Entregable
    {
        public string titulo { get; set; }
        public int numTemp { get; set; }
        public bool entregado { get; set; }
        public string genero { get; set; }
        public string creador { get; set; }

        public Serie()
        {
            titulo = "-";
            numTemp = 3;
            entregado = false;
            genero = "-";
            creador = "-";
        }

        public Serie(string Titulo, string Creador)
        {
            this.titulo = Titulo;
            numTemp = 3;
            entregado = false;
            genero = "-";
            this.creador = Creador;
        }

        public Serie(string Titulo, int NumTemp, string Genero, string Creador) 
        {
            this.titulo= Titulo;
            this.numTemp = NumTemp;
            entregado = false;
            this.genero = Genero;
            this.creador = Creador;
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
        
        public override string ToString()
        {
            return "Título: " + titulo + "Temporadas: " + numTemp+ "Género: "+genero + "Creador: " + creador + "Entregado: " + entregado;
        }


    }
}
