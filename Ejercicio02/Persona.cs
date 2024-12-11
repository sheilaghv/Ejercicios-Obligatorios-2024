using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Persona
    {
       
        private const char SEXO_DEFECTO = 'H';
        private const int IMCBAJO = -1;
        private const int IMCIDEAL = 0;
        private const int IMCALTO = 1;

     
        private string nombre = "";
        private int edad = 0;
        private string dni;
        private char sexo = SEXO_DEFECTO;
        private double peso = 0;
        private double altura = 0;

      
        public Persona() { }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
            this.dni = generaDNI();
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
            : this(nombre, edad, sexo)
        {
            this.peso = peso;
            this.altura = altura;
        }

      
        public int calcularIMC()
        {
            double imc = peso / (altura * altura);
            if (imc < 20) return IMCBAJO;
            else if (imc <= 25) return IMCIDEAL;
            else return IMCALTO;
        }

        public bool esMayorDeEdad() => edad >= 18;

        private char comprobarSexo(char sexo) => (sexo == 'H' || sexo == 'M') ? sexo : SEXO_DEFECTO;

        private string generaDNI()
        {
            Random rnd = new Random();
            int numero = rnd.Next(10000000, 99999999);
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            char letra = letras[numero % 23];
            return $"{numero}{letra}";
        }

        public void Nombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Edad(int edad)
        {
            this.edad = edad;
        }

        public void Sexo(char sexo)
        {
            this.sexo = comprobarSexo(sexo);
        }

        public void Peso(double peso)
        {
            this.peso = peso;
        }

        public void Altura(double altura)
        {
            this.altura = altura;
        }


        public override string ToString()
        {
            return $"Nombre: {nombre}, Edad: {edad}, DNI: {dni}, Sexo: {sexo}, Peso: {peso}kg, Altura: {altura}m";
        }
    }
}
