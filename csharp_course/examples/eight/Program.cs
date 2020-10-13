using System;

namespace eight
{
    class Quiz  // Una clase es un contenedor de métodos y variables
    {
        // Esto es público
        public string question;
        public string answer;
        public int points;

        // Esto es publico
        public void CreateQuiz(string q, string a, int p) // Esto es un método con parametros
        {
            question = q;
            answer = a;
            points = p;
            // Console.WriteLine("¡Se ha creado una nueva encuesta!\nLa pregunta es: {0}\nLa respuesta es: {1}\nLos puntos a obtener son {2}pts", question, answer, points);
        }
    }

    class Program
    {
        static void Main(string[] args) // Esto es un método estático
        {
            Quiz quiz1 = new Quiz(); // Clonamos Quiz
            Quiz quiz2 = new Quiz();
            Quiz quiz3 = new Quiz();
            Quiz quiz4 = new Quiz();
            Quiz quiz5 = new Quiz();
            quiz1.CreateQuiz("¿De que color es una manzana?","Roja", 10);
            quiz2.CreateQuiz("¿Cuanto es 5 + 7?","12", 12);
            quiz3.CreateQuiz("¿Cual es la capital de Venezuela?","Caracas", 20);
            quiz4.CreateQuiz("¿Quien perdió la segunda guerra mundial?","Alemania", 35);
            quiz5.CreateQuiz("¿Quien escribio 100 años de soledad?","Gabriel Garcia Marquez", 17);
                            // Pregunta                             // Respuesta         // Puntos

            Console.WriteLine("¡Bienvenidos a preguntados!\nTe haremos una pregunta aleatoria de las 5 disponibles\nPresiona una tecla para continuar >>>");
            Console.ReadKey(); // Esperar a que el usuario presione cualquier tecla

            int questions = 0;

            do
            {
                Random rng = new Random(); // Clonamos a Random
                int randomQuestion = rng.Next(1, 6);
                string answer;

                switch (randomQuestion)
                {
                    case 1:
                        Console.WriteLine(quiz1.question);
                        answer = Console.ReadLine();
                        if(answer == quiz1.answer)
                        {
                            Console.WriteLine("¡Correcto!");
                        } else
                        {
                            Console.WriteLine("Incorrecto");
                        }
                        break;
                    case 2:
                        Console.WriteLine(quiz2.question);
                        answer = Console.ReadLine();
                        if(answer == quiz2.answer)
                        {
                            Console.WriteLine("¡Correcto!");
                        } else
                        {
                            Console.WriteLine("Incorrecto");
                        }
                        break;
                    case 3:
                        Console.WriteLine(quiz3.question);
                        answer = Console.ReadLine();
                        if(answer == quiz3.answer)
                        {
                            Console.WriteLine("¡Correcto!");
                        } else
                        {
                            Console.WriteLine("Incorrecto");
                        }
                        break;
                    case 4:
                        Console.WriteLine(quiz4.question);
                        answer = Console.ReadLine();
                        if(answer == quiz4.answer)
                        {
                            Console.WriteLine("¡Correcto!");
                        } else
                        {
                            Console.WriteLine("Incorrecto");
                        }
                        break;
                    case 5:
                        Console.WriteLine(quiz5.question);
                        answer = Console.ReadLine();
                        if(answer == quiz5.answer)
                        {
                            Console.WriteLine("¡Correcto!");
                        } else
                        {
                            Console.WriteLine("Incorrecto");
                        }
                        break;
                    default:
                        Console.WriteLine("No tengo preguntas");
                        break;
                }
                questions++;

            } while (questions <= 5);
        }
    }
}
