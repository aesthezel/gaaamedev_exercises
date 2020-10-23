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
        class Dice
    {
        public string _diceName;
        public int _diceFaces;
        public int result;

        public void CreateDice(string name, int faces) // Argumentos
        {
            _diceName = name;
            _diceFaces = faces;
            // Console.WriteLine("El dado {0} tiene {1} caras.", name, faces);
        }
    }
}