using System;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            int suma = 0;
           


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());

                suma += numeros[i];


            }



            Console.WriteLine("Numeros Almacenados");

            for (int i = 0; i < numeros.Length; i++)
            {


                Console.WriteLine(numeros[i]);

            }

            int mayor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }

            int menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.WriteLine($"Numero mayor: {mayor}");
            Console.WriteLine($"Numero menor: {menor}");



            Console.WriteLine($"Suma total: {suma}");

            double promedio = (double)suma / numeros.Length;

            Console.WriteLine($"Promedio: {promedio}");

            Console.ReadKey();
        }
    }
}
