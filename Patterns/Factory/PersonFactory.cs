using System;

namespace Patterns.Factory
{
    public interface IPerson
    {
        string GetName();
    }

    public class Villager : IPerson
    {
        public string GetName() => "Village Person";
    }

    public class CityPerson : IPerson
    {
        public string GetName() => "City Person";
    }

    public enum PersonType
    {
        Rural,
        Urban
    }

    public class PersonFactory
    {
        public IPerson GetPerson(PersonType type)
        {
            return type switch
            {
                PersonType.Rural => new Villager(),
                PersonType.Urban => new CityPerson(),
                _ => throw new NotImplementedException()
            };
        }
    }
}