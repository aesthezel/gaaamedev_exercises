/**
    gAAAmedev - Ejercicio #9
    Por determinar
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
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 10; i++)
            {
                if (i == 6)
                {   
                    Console.WriteLine("¡Estoy en la sexta iteración!");
                    break;
                }
            }
            Console.WriteLine("Se acabó el programa...");
            Console.ReadKey();
        }
    }
}
