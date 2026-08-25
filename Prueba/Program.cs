using System;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar una palabra: ");
            string palabra = Console.ReadLine().ToLower();

            palabra = palabra.Trim();
            Console.WriteLine(palabra);
            Console.WriteLine(palabra.Replace("a","@"));


            if (palabra.Length >= 3)
            {
                Console.WriteLine(palabra.Substring(0, 3));
            }
            else
            {
                Console.WriteLine("La palabra tiene menos de 3 caracteres.");
            }




            Console.ReadKey();
        }
    }
}