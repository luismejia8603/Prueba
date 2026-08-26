using System;

namespace Prueba
{
    internal class Program
    {
        static double CalcularPromedio (double numero1, double numero2, double numero3) 
        { 
            double total = (numero1 + numero2 + numero3)/3;


            return total;
        }

        static bool Aprobado(double promedio)
        {
            bool aprobado = false;

            if (promedio >= 6)
            {
                return true;
            }
            else 
            {
                return false;
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar número 1: ");
            double nota1 = double.Parse(Console.ReadLine());

  
            Console.WriteLine("Ingresar nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());



            double total = CalcularPromedio(nota1, nota2,nota3);

            Console.WriteLine($"Nota promedio es: {total:F2}");

            bool estado = Aprobado(total);

            if (estado == true)
            {
                Console.WriteLine("El estudiante aprobó :)");
            }
            else 
            {
                Console.WriteLine("El estudiante reprobó :(");
            }


            Console.ReadKey();
        }
    }
}