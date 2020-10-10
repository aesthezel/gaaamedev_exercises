/**
    gAAAmedev - Ejercicio #3
    Uso del swtich y operadores
    ---
    @autor David <Aesthezel> Pino
    @see gAAAmedev
    ---
    El contenido debe ser utilizado para fines académicos
*/

using System;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int coins = 25;
            int stealthAbility = 1; // Habilidad para robar

            #region Version IF-ELSEIF-IF
            /* VERSION IF-ELSEIF-ELSE 

            Console.WriteLine("Tienes {0} monedas, elije una opción", coins);
            Console.WriteLine("Opción 1 (50 monedas) | {0} Habilidad para robar >>>\nOpción 2 (100 monedas) | {0} Habilidad para robar >>>", stealthAbility);
            option = Convert.ToInt32(Console.ReadLine());

            if(option == 1 && coins >= 50 || stealthAbility == 1)
            {
                if(stealthAbility != 0)
                {
                    Console.WriteLine("*Has tomado la elección {0} sin que nadie te haya visto...*", option);
                    Console.WriteLine("*Tu saldo es {0} monedas*", coins);
                    stealthAbility = stealthAbility - 1;
                    Console.WriteLine("Tu habilidad de robar se ha disminuido a {0}", stealthAbility);
                    Console.ReadKey(); 
                } else 
                {
                    Console.WriteLine("Aquí tienes, gracias por su elección");
                    coins = coins - 50;
                    Console.WriteLine("*Tu saldo restante es {0} monedas*", coins);
                    Console.ReadKey();
                }
            } 
            else if (option == 2 && coins >= 100)
            {
                if(stealthAbility != 0)
                {
                    Console.WriteLine("*Has tomado la elección {0} sin que nadie te haya visto...*", option);
                    Console.WriteLine("*Tu saldo es {0} monedas*", coins);
                    stealthAbility = stealthAbility - 1;
                    Console.WriteLine("Tu habilidad de robar se ha disminuido a {0}", stealthAbility);
                    Console.ReadKey();                   
                } 
                else 
                {
                    Console.WriteLine("Aquí tienes, gracias por su elección");
                    coins = coins - 100;
                    Console.WriteLine("*Tu saldo restante es {0} monedas*", coins);
                    Console.ReadKey(); 
                } 
            }
            else
            {
                Console.WriteLine("No tienes el dinero suficiente, largo de aquí...");
                Console.WriteLine("*Tengo {0} monedas...*", coins);
                Console.ReadKey();
            }

            FIN DE VERSION IF-ELSEIF-ELSE */

            /* VERSION SWITCH */
            #endregion

            Console.WriteLine("Tienes {0} monedas, elije una opción", coins);
            Console.WriteLine("Opción 1 (50 monedas) | {0} Habilidad para robar >>>\nOpción 2 (100 monedas) | {0} Habilidad para robar >>>", stealthAbility);
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1 when coins >= 50:
                    Console.WriteLine("Aquí tienes, gracias por su elección");
                    coins = coins - 50;
                    Console.WriteLine("*Tu saldo restante es {0} monedas*", coins);
                    Console.ReadKey();
                    break;  
                case 2 when coins >= 100:
                    Console.WriteLine("Aquí tienes, gracias por su elección");
                    coins = coins - 100;
                    Console.WriteLine("*Tu saldo restante es {0} monedas*", coins);
                    Console.ReadKey();  
                    break;      
                case 1 when stealthAbility > 0:
                case 2 when stealthAbility > 0:
                    Console.WriteLine("*Has tomado la elección {0} sin que nadie te haya visto...*", option);
                    Console.WriteLine("*Tu saldo es {0} monedas*", coins);
                    stealthAbility = stealthAbility - 1;
                    Console.WriteLine("Tu habilidad de robar se ha disminuido a {0}", stealthAbility);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("No tienes el dinero suficiente, largo de aquí...");
                    Console.WriteLine("*Tengo {0} monedas...*", coins);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
