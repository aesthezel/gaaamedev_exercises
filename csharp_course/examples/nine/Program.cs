/**
    gAAAmedev - Ejercicio #9
    Prueba de Git
    ---
    @autor David <Aesthezel> Pino
    @see gAAAmedev
    ---
    El contenido debe ser utilizado para fines académicos
*/

using System;

namespace nine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este documento es una prueba de Git y GitAhead");

            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                {   
                    Console.WriteLine("Bienvenidos al uso de Git");
                    break;
                }
            }
            Console.WriteLine("Se acabó el programa...");
            Console.ReadKey();
        }
    }
}
