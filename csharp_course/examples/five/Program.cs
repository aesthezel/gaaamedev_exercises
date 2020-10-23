/**
    gAAAmedev - Ejercicio #5
    For & Foreach
    ---
    @autor David <Aesthezel> Pino
    @see gAAAmedev
    ---
    El contenido debe ser utilizado para fines académicos
*/

using System;

namespace five
{

    class Program
    {
        static void Main(string[] args)
        {
            int laps = 10; // Vueltas que hará

            int topLaps = 0; // Las mejores vueltas
            int[] lapsHighestVelocity = {290, 230, 250, 260, 270, 295, 280, 233, 246, 225}; // Array de enteros, con las mejores vueltas
            int velocity = 0; // Contenedor para las velocidades

            /* 
                Estructura base de un For:

                        Valor I. | Condición | Incremento
                    for (int i = 0; i < length; i++)
                    {
                        // Algo que hacer
                    }

                • Su estructura se basa en un:
                    ○ Valor Inicial (int i = 0)
                    ○ Condición (i < length)
                    ○ Incremento (i++), PD: el operador ++ es una forma reducida de decir i = i + 1;
                • Al cumplirse la condición la iteración dará lugar a continuar la ejecución del código fuera del for
                • Técnicamente un for es una manera de arreglar algo parecido a un while pero de manera más ordenada y limpia

            */

            for (int lap = 1; lap <= laps; lap++)
            {
                Random randomVelocity = new Random();
                velocity = randomVelocity.Next(0, 301); // Para que llegue a 300 se debe agregar 1 número extra por que el Random funciona de manera exclusiva, es decir tomará los valores de internos al limite.

                Console.WriteLine("Has dado una vuelta, esta es tu {0} vuelta y lo lograstes a una velocidad de {1}Km/H", lap, velocity);
            }
            Console.WriteLine("\nSe ha finalizado la carrera");

                    // Identificador I.     // Contenedor
            foreach (var highestLap in lapsHighestVelocity)
            {
                topLaps++; // La primera vuelta esto valdrá 1
                Console.WriteLine("En la vuelta {0} la mejor velocidad registrada es de {1}Km/H", topLaps, highestLap);
            }
        }
    }
}
