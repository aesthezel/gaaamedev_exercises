using System;

namespace seven
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;

            Console.WriteLine("Ingrese un número");
            value = Convert.ToInt32(Console.ReadLine());

            while (value < 10) // While significa Mientras
            {
                Console.WriteLine("Dentro del While el valor vale {0}", value);
                value++;

                if(value == 5)
                {
                    Console.WriteLine("Epa el valor vale {0}, me voy a salir.", value);
                    break;
                }

            }
            Console.WriteLine("Fuera del While el valor vale {0}", value);
        }
    }
}
