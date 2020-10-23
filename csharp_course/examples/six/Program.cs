/**
    gAAAmedev - Ejercicio #6
    Práctica: Dado
    ---
    @autor David <Aesthezel> Pino
    @see gAAAmedev
    ---
    El contenido debe ser utilizado para fines académicos
*/

using System;

namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int condition;
            Dice d1 = new Dice();
            Dice d2 = new Dice();
            d1.CreateDice("Dado básico", 5);
            d2.CreateDice("Dado supremo", 9);
            // Console.WriteLine("El nombre del dado es: {0} y el otro dado se llama: {1}", d1._diceName, d2._diceName);

            do
            {
                Console.WriteLine("Lanza los dados y prueba tu suerte:");
                Random rng = new Random();
                Random rng2 = new Random();
                d1.result = rng.Next(1, d1._diceFaces + 1);
                d2.result = rng2.Next(1, d2._diceFaces + 1);
                result = d1.result + d2.result;

                Console.ReadKey();

                condition = result % 2;

                if(condition == 1) // Si pierdes
                {
                    Console.WriteLine("Has perdido, el primer dado dió {0} y el segundo dado dió {1}, y su suma es {2}, por lo que no es par.", d1.result, d2.result, result);
                    Console.ReadKey();
                }

                Console.Clear();

            } while (condition != 0); // Cuando no sea la condición se repetirá

            Console.WriteLine("Has ganado, el primer dado dió {0} y el segundo dado dió {1}, y su suma es {2}, por lo que es par.", d1.result, d2.result, result);
            Console.ReadKey();
        }
    }
}
