using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public class Libros
    {
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumPaginas { get; set; }

        public Libros(int isbn, string titulo, string autor, int numpaginas) 
        {
           this.ISBN = isbn;
           this.Titulo = titulo;
           this.Autor = autor;
           this.NumPaginas = numpaginas;
        }

        public override string ToString()
        {
            return "ISBN: " + ISBN +"Titulo: " + Titulo + "Autor: " + Autor + "Paginas: " + NumPaginas;
        }
    }
}
