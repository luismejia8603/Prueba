using System;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3, 3];



            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write($"Ingrese número para fila {fila + 1}, columna {columna + 1}: ");
                    numeros[fila, columna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz almacenada:");



            for (int fila = 0; fila < 3; fila++)
            {

                for (int columna = 0; columna < 3; columna++)
                {

                    Console.Write(numeros[fila, columna] + " ");

                }

                Console.WriteLine();

            }

            Console.WriteLine();

            int suma = 0;

            for (int fila = 0; fila < 3; fila++)
            {

                int sumaFila = 0;

                for (int columna = 0; columna < 3; columna++)
                {


                    sumaFila += numeros[fila, columna];
                    suma += numeros[fila, columna];
                }


                Console.WriteLine($"Suma de la fila {fila + 1}: {sumaFila}");

            }

            for (int columna = 0; columna < 3; columna++)
            {

                int sumacolumna = 0;

                for (int fila = 0; fila < 3; fila++)
                {


                    sumacolumna += numeros[fila, columna];

                }


                Console.WriteLine($"Suma de la columna {columna + 1}: {sumacolumna}");

            }

            int numeroMayor = numeros[0, 0];
            int numeroMenor = numeros[0, 0];

            int pares = 0;
            int impares = 0;

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {

                    if (numeros[fila, columna] > numeroMayor)
                    {
                        numeroMayor = numeros[fila, columna];

                    }

                    if (numeros[fila, columna] < numeroMenor)
                    {
                        numeroMenor = numeros[fila, columna];
                    }

                    if ((numeros[fila,columna]) % 2 == 0)
                    {
                        pares++;

                    }

                    else 
                    {
                    
                       impares++;
                    
                    }

                }



            }

            Console.WriteLine($"\nSuma total: {suma}");

            Console.WriteLine($"Mayor: {numeroMayor}");
            Console.WriteLine($"Menor: {numeroMenor}");

            Console.WriteLine($"Pares: {pares}");
            Console.WriteLine($"Impares: {impares}");


            Console.WriteLine("Ingresar número que desea buscar: ");
            int numeroBuscar = int.Parse( Console.ReadLine() );



            int contador = 0;

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    if (numeros[fila, columna] == numeroBuscar)
                    {
                        Console.WriteLine($"Encontrado en fila {fila + 1}, columna {columna + 1}");
                        contador++;
                    }
                }
            }

            if (contador == 0)
            {
                Console.WriteLine($"El número {numeroBuscar} no fue encontrado.");
            }
            else if (contador == 1)
            {
                Console.WriteLine($"El número {numeroBuscar} fue encontrado {contador} vez.");
            }
            else
            {
                Console.WriteLine($"El número {numeroBuscar} fue encontrado {contador} veces.");
            }

            Console.ReadKey();
        }
    }
}