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
            return new string(Enumerable.Range(0, Longitud).Select( => caracteres[random.Next(caracteres.Length)]).ToArray());
        }

        public bool EsFuerte() =>
            Contraseña.Count(char.IsUpper) > 2 &&
            Contraseña.Count(char.IsLower) > 1 &&
            Contraseña.Count(char.IsDigit) > 5;
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Cantidad de contraseñas: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Longitud de las contraseñas: ");
            int longitud = int.Parse(Console.ReadLine());

            var passwords = Enumerable.Range(0, cantidad).Select( => new Password(longitud)).ToList();

            passwords.ForEach(p => Console.WriteLine($"{p.Contraseña} {p.EsFuerte()}"));
        }
    }
}
