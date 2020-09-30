/**
    gAAAmedev - Ejercicio #2
    Condicionales y operadores
    ---
    @autor David <Aesthezel> Pino
    @see gAAAmedev
    ---
    El contenido debe ser utilizado para fines académicos
*/

using System;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberChoise = 0;   // Debe declararse un valor base si despues se quiere usar dentro de un if

            Console.WriteLine("Bienvenido a gAAAmedev, elija una de las dos opciones...");
            Console.WriteLine("\n1. ¿Que son los operadores relacionales?\n2. ¿Que son los operadores lógicos?");
            numberChoise = Convert.ToInt32(Console.ReadLine()); // Hay que convertir la función a un entero de 32-bit (INT)
            // ALERTA: Si no se ingresa un número entero, o se asigna una aletra o simbolo el programa indicará error y se terminará forzosamente
            Console.Clear(); // Limpia la consola

            if(numberChoise == 1)
            {
                Console.WriteLine("--- Operadores relacionales ---");
                Console.WriteLine("< Menor que\n> Mayor que\n<= Menor o igual que\n>= Mayor o igual que\n== Igual a\n!= No es igual");
                Console.WriteLine("\nPresione una tecla para salir del programa...");
                Console.ReadKey();
            }
            else if (numberChoise == 2) // Si la primera condición no se cumple, va a esta condición.
            {
                Console.WriteLine("--- Operadores lógicos ---");
                Console.WriteLine("&& Y\n|| O\n! No");
                Console.WriteLine("\nPresione una tecla para salir del programa...");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Opción no disponible, presiona una tecla para finalizar el programa...");
                Console.ReadKey();
            }
        }
    }
}
