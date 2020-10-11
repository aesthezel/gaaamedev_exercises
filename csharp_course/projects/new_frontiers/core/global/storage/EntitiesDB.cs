using System;
using System.Collections.Generic;

namespace new_frontiers
{
    public class EntitiesDB
    {
        public List<Entity> entities = new List<Entity>();

        public void CreateNewEntity(string name, int age, float weight, float height, Entity.Type type)
        {
            Entity newEntity = new Entity();
            newEntity.SetEntity(name, age, weight, height, type);

            entities.Add(newEntity);
        }
    }
}