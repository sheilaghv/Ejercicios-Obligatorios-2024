﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    public class Profesor 
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public string Materia { get; set; }

        public Profesor(string nombre, int edad, char sexo, string materia) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Materia = materia;        
        }

        public bool EstaDisponible()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100) >= 20;
        }
    }
}
