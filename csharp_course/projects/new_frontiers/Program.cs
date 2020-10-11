using System;

namespace new_frontiers
{
    class Program
    {

        static void Main(string[] args)
        {
            //EntitiesDB eDB = new EntitiesDB();
            Player pj1 = new Player();
            pj1.CreatePlayer("David", 24, 65.5f, 1.8f);
            pj1.CreatePlayer("Alejandro", 24, 65.5f, 1.8f);
            Console.WriteLine(pj1.GetPlayer("David"));

            //Console.WriteLine(pj1.GetPlayer("David"));
        }
    }
}
