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
            int mayusculas = 0, minusculas = 0, digitos = 0;
        
            foreach (char c in Contraseña)
            {
                if (char.IsUpper(c)) mayusculas++;
                else if (char.IsLower(c)) minusculas++;
                else if (char.IsDigit(c)) digitos++;
            }
        
            return mayusculas > 2 && minusculas > 1 && digitos > 5;
        }

    class Program
    {
        static void Main()
        {
            Console.Write("Cantidad de contraseñas: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Longitud de las contraseñas: ");
            int longitud = int.Parse(Console.ReadLine());

           List<Password> passwords = new List<Password>();

        for (int i = 0; i < cantidad; i++) //cuantas veces se va a repetir
        {
            passwords.Add(new Password(longitud)); //añade la contraseña a la lista
        }
        
                  
        foreach (var password in passwords)
        {
            Console.WriteLine(password); //
        }

            passwords.ForEach(p => Console.WriteLine($"{p.Contraseña} {p.EsFuerte()}"));
        }
    }
}
