/*
    gAAAmedev - Ejercicio #1
    Variables y su uso
    ---
    Realizado por David <Aesthezel> Pino
    hola@aesthezel.site
    ---
    El contenido debe ser utilizado para fines académicos
*/

using System;   // Libreras

namespace one   // Conjunto de trabajo
{
    class Program   // Clase principal
    {
        static void Main(string[] args)     // Primer método que ejecuta el terminal
        {
            // Variables más comunes
            int integrerNumber = 1;         // Una variable de tipo entero de 32bits
            float singleDecimal = 3.3f;     // Variable de tipo flotante simple (soporta decimales)
            string wordText = "Hello";      // Contenedor de texto, se necesitan usar comillas dobles "" rodeando el texto
            bool working = false;           // Son prácticamente un interruptor que te indica si es verdadero o falso

            Console.WriteLine("Bienvenidos a gAAAmedev\nA continuación, usaremos las variables antes propuestas...");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Leyendo las cuatro variables en orden:");
            Console.WriteLine("El valor de su INT es: {0}\nEl valor de su FLOAT es: {1}\nEl valor de su STRING es: \"{2}\"\nEl valor de su BOOL es: {3}", integrerNumber, singleDecimal, wordText, working);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Fin del programa");
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey(); 
            // FIN DEL PROGRAMA

            /*

                Terminos utilizados
                • Console.WriteLine(); -- Escribe texto en la consola, el reconoce cadenas de texto dentro de las comillas dobles ("") y se le pueden asignar variables que se reproduzcan en el texto con llaves ejemplo Console.WriteLine("{0} {1}", var1, var2);
                • Console.ReadKey(); -- Espera a que toquemos cualquier tecla para continuar
                • Console.Clear(); -- Limpia el texto de la consola
                • \n dentro del texto de Console.WriteLine(); -- Estos se le nombra como "secuencias escape" y esta en particular es cómo si hicieramos un Intro en nuestro teclado cuando escribimos para generar un nuevo parrafo
                • \" dentro del texto de Console.WriteLine(); -- Sirve para escribir una comilla doble dentro de un texto que tiene comillas dobles y no generar un error de tipeado

            */
        }
    }
}
