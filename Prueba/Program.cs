using System;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];

            

            

           


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());



            }

            int suma = 0;
            int mayor = numeros[0];
            int menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)

                    mayor = numeros[i];
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }

            }

            int pares = 0;
            int impares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
                suma= suma+numeros[i];

                if (numeros[i] %2 == 0)
                {

                    pares++;

                }

                else 
                {

                    impares++;
                
                }



            }

            Console.WriteLine($"La suma de los numeros es: {suma}");

            double promedio = (double)suma / numeros.Length;

            Console.WriteLine($"El promedio es: {promedio}");

            Console.WriteLine($"El numero mayor es: {mayor}");
            Console.WriteLine($"El numero menor es: {menor}");
            Console.WriteLine($"Pares son: {pares}");
            Console.WriteLine($"Impares son: {impares}");



            Console.Write("Numero a buscar: ");
            int numeroBuscar = int.Parse( Console.ReadLine() );
            int contador = 0;

            for (int i = 0; i < numeros.Length; i++) 
            
            {

                if (numeroBuscar == numeros[i])
                {
                    Console.WriteLine($"El numero {numeroBuscar} aparece en la posición {i + 1}");
                    contador++;
                }
            
            }

            if (contador == 1)
            {

                Console.WriteLine($"El numero {numeroBuscar} aparece {contador} vez");

            }

            else if (contador > 1)
            {

                Console.WriteLine($"El numero {numeroBuscar} aparece {contador} veces");

            }

            else 
            {

                Console.WriteLine($"El numero {numeroBuscar} no está en el arreglo");

            }


            





            Console.ReadKey();

        }
    }
}
