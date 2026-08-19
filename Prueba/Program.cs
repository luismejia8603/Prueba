using System;
using System.Timers;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            int contador = 0;

           


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());



            }

            Console.WriteLine("Ingresar número que desea reemplazar");
            int numeroReemplazar = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar por cual número desea cambiar");
            int numeroNuevo = int.Parse(Console.ReadLine());


            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroReemplazar)
                {
                    numeros[i] = numeroNuevo;
                    contador++;
                }
            }

            if (contador == 1)

            {

                Console.WriteLine($"El numero {numeroReemplazar} se reemplazó {contador} vez");



            }

            else if (contador > 1)
            {

                Console.WriteLine($"El numero {numeroReemplazar} se reemplazó {contador} veces");
            }

            else 
            { 
            
                Console.WriteLine($"El número {numeroReemplazar} no se reemplazó porque no está en el arreglo");
            
            
            }


            if (contador > 0)
            {
                Console.WriteLine("Arreglo actualizado:");

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            






            Console.ReadKey();

        }
    }
}
