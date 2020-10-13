using System;

namespace new_frontiers
{
    public class EntityManager
    {
        string _consoleTag = "[EntityManager]";
        EntitiesDB entitiesDB = new EntitiesDB();

        public void CreateEntity(string name, int age, float weight, float height, int type)
        {
            switch(type)
            {
                case 0:
                    entitiesDB.AddEntity(name, age, weight, height, (Entity.Type.Player));
                    Console.WriteLine("{0} La entidad {1}, ha sido creada como un jugador...", _consoleTag, name);
                    break;
                case 1:
                    entitiesDB.AddEntity(name, age, weight, height, (Entity.Type.Enemy));
                    Console.WriteLine("{0} La entidad {1}, ha sido creada como un enemigo...", _consoleTag, name);
                    break;
                default:
                    entitiesDB.AddEntity(name, age, weight, height, (Entity.Type.Neutral));
                    Console.WriteLine("{0} La entidad {1}, ha sido creada como un neutral...", _consoleTag, name);
                    break;
            }   
        }

        public void GetEntity (string name)
        {
            foreach (var entity in entitiesDB.entities)
            {
                if(name == entity.GetName())
                {
                    Console.WriteLine("{0} ¡El jugador {1} ha sido encontrado! Su ID es {2}", _consoleTag, entity.GetName(), Convert.ToString(entity.GetID()));
                    return;
                }
                
            }
            Console.WriteLine("No se ha encontrado el jugador \"{0}\"", name);
        }
    }
}