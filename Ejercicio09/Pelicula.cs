using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public int EdadMinima { get; set; }
        public string Director {  get; set; }

        public Pelicula(string titulo, int duracion, int edadminima, string director) 
        {
            this.Titulo = titulo;
            this.Duracion = duracion;
            this.EdadMinima = edadminima;
            this.Director = director;


        }
        public override string ToString()
        {
            return $"Título: {Titulo}, Duración: {Duracion} minutos, Edad Mínima: {EdadMinima}, Director: {Director}";
        }
    }
}
