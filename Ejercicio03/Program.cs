using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Password
    {
        public int Longitud { get; set; }
        public string Contraseña { get; private set; }

        public Password(int longitud = 8)
        {
            Longitud = longitud;
            Contraseña = GenerarPassword();
        }

        private string GenerarPassword()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] password = new char[Longitud];

            for (int i = 0; i < Longitud; i++)
            {
                password[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new string(password);
        }

        public bool EsFuerte()
        {
            int mayusculas = 0;
            int minusculas = 0;
            int numeros = 0;

            foreach (char c in Contraseña)
            {
                if (char.IsUpper(c)) mayusculas++;
                else if (char.IsLower(c)) minusculas++;
                else if (char.IsDigit(c)) numeros++;
            }

            return mayusculas > 2 && minusculas > 1 && numeros > 5;
        }

        class Program
        {
            static void Main()
            {
             
                Console.Write("Cantidad de contraseñas para generar: ");
                int cantidad = int.Parse(Console.ReadLine());

                Console.Write("Longitud de las contraseñas: ");
                int longitud = int.Parse(Console.ReadLine());

                Password[] passwords = new Password[cantidad];
              
                bool[] esFuerte = new bool[cantidad];

              
                for (int i = 0; i < cantidad; i++)
                {
                    passwords[i] = new Password(longitud);
                    esFuerte[i] = passwords[i].EsFuerte(); // verifica si es fuerte
                }

                // muestra las contraseñas y si son fuertes o no
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine(passwords[i].Contraseña + " " + esFuerte[i]);
                }

                Console.ReadKey();
            }
        }
    }
}

