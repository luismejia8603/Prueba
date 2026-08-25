using System;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresar una palabra: ");
            string palabra = Console.ReadLine().Trim();

            Console.WriteLine(palabra.ToUpper());

            string invertida = "";

            Console.WriteLine($"Original: {palabra}");
            
            for (int i = palabra.Length-1; i >= 0; i--)
            {
                invertida += palabra[i];

                
            }

            Console.WriteLine($"Invertida: {invertida}");

            if (palabra == invertida)
            {
                Console.WriteLine("La palabra es palíndromo.");
            }
            else
            {
                Console.WriteLine("La palabra no es palíndromo.");
            }




            Console.ReadKey();
        }
    }
}