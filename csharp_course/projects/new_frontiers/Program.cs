using System;

namespace new_frontiers
{
    class Program
    {

        static void Main(string[] args)
        {
            //EntitiesDB eDB = new EntitiesDB();
            EntityManager eMan = new EntityManager();
            eMan.CreateEntity("David", 24, 65.5f, 1.8f, 0);
            eMan.CreateEntity("Marley", 20, 50.2f, 1.55f, 0);
            eMan.CreateEntity("Rebecca", 22, 58.3f, 1.4f, 1);
            eMan.GetEntity("Marley");
        }
    }
}
