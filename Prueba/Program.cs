using System;


namespace Prueba
{
    internal class Program
    {
        static string EvaluarEdad(int edad)
        {
            if (edad < 1 || edad > 120)
            {
                return "Edad Invalida";
            }

            else if (edad >= 18)
            {
                return "Mayor de edad";
            }

            else 
            {
                return "Menor de edad";
            }

        }


        static void MostrarResultado(string nombre, string estado) 
        {
            Console.Write($"{nombre}: {estado}");
        }

        
        static void Main(string[] args)
        {

            Console.Write("Ingresar nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresar edad: ");
            int edad = int.Parse(Console.ReadLine());

            string estado = EvaluarEdad(edad);

            MostrarResultado(nombre, estado);
            

            Console.ReadKey();
        }
    }
}
