using System;

namespace new_frontiers
{
    public class Entity
    {
        public static int idCount;
        int _id;
        string _name;
        string _title;
        int _age;
        float _weight;
        float _height;
        float _speed;

        public enum Type
        {
            Player,
            Enemy,
            Neutral
        }

        enum Status
        {
            Alive,
            Attacking,
            Defending,
            Walking,
            Reading,
            Eating,
            Sleeping,
            Death
        }

        enum Ethnicity
        {
            Human,
            Animal,
            Kaakzan,
            Paalk,
            Void
        }

        Type _type;
        Status _state;
        Ethnicity _ethnic;

        public void SetEntity(string n, int a, float w, float h, Type t)
        {
            idCount++;
            _id = idCount;
            _name = n;
            _age = a;
            _weight = w;
            _height = h;
            _type = t;
            _speed = (w / h) * 2;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetID()
        {
            return _id;
        }
    }
}