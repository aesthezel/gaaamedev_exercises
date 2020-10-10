/**
    gAAAmedev - Ejercicio #4
    While & Do while
    ---
    @autor David <Aesthezel> Pino
    @see gAAAmedev
    ---
    El contenido debe ser utilizado para fines académicos
*/

using System;

namespace four
{
    public class Greetings
    {
        public void SayHi()
        {
            Console.WriteLine("Soy el ejercicio número 4 de gAAAmedev");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            int input;
            int password = 6504;
            int coins = 0;

            Console.WriteLine("--- While & Do While ---\n");
            Console.WriteLine("Realizamos la iteración con While");
            Console.WriteLine("Presiona una tecla para continuar >>>");
            Console.ReadKey();
            Console.Clear();
            
            //Iteración con While
            while (coins <= 10)
            {
                Console.WriteLine("Monedas en el baúl {0}", coins);
                coins++;
            }

            Console.WriteLine("While finalizado... Presione una tecla para continuar >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ahora realizamos la iteración con Do while");
            Console.WriteLine("Presiona una tecla para continuar >>>");
            Console.ReadKey();
            Console.Clear();

            // Iteración con DO
            do
            {

                Console.WriteLine("Introduzca su clave del cajero automático:");
                input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if(input != password)
                {
                    Console.WriteLine("Clave inválida, intente de nuevo");
                    Console.WriteLine("Reintentar >>>");
                    Console.ReadKey();
                    Console.Clear();
                } 
                else
                {
                    Console.WriteLine("C O R R E C T O");
                    Console.WriteLine("Presione una tecla para continuar >>>");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (input != password);

            Random randomCoins = new Random();
            coins = randomCoins.Next(0, 1000);
            Console.WriteLine("Monedas en la cuenta: {0} monedas", coins);
        }
    }
}
