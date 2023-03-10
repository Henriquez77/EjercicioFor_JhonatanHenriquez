using System;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el tamaño del triangulo a generar: ");
            var tamaño = int.Parse(Console.ReadLine());
            //i columnas
            //j filas
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
