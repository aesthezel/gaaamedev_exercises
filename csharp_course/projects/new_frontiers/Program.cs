using System;

namespace new_frontiers
{
    class Program
    {

        static void Main(string[] args)
        {
            //EntitiesDB eDB = new EntitiesDB();
            EntityManager eMan = new EntityManager();

            Console.WriteLine("¡Bienvenido a New Frontiers!");
            Console.WriteLine("Dime tu nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Dime tu edad");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime tu peso");
            float weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Dime tu estatura");
            float height = Convert.ToSingle(Console.ReadLine());

            eMan.CreateEntity(name, age, weight, height, 0);
            eMan.GetEntity(name);
        }
    }
}
