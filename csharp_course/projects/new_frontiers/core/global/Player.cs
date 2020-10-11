using System;

namespace new_frontiers
{
    public class Player
    {
        EntitiesDB entitiesDB = new EntitiesDB();
        
        public void CreatePlayer(string name, int age, float weight, float height)
        {
            entitiesDB.CreateNewEntity(name, age, weight, height, Entity.Type.Player);
        }

        public string GetPlayer (string name)
        {
            foreach (var player in entitiesDB.entities)
            {
                if(name == player.GetName())
                {
                    return "Jugador " + player.GetName() + " encontrado, su ID es: " + Convert.ToString(player.GetID());
                }
                
            }
            return "No se ha encontrado el jugador \'"+name+"\'...";
        }
    }
}