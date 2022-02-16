namespace Patterns.AbstractFactory
{
    public class Villager
    {
        public Villager(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    public class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    public abstract class PersonAbstractFactory
    {
        public abstract Villager GetVillager();
        public abstract Animal GetAnimal();
    }

    public class OldPersonFactory : PersonAbstractFactory
    {
        public override Villager GetVillager() => new Villager("Old");

        public override Animal GetAnimal() => new Animal("Old");
    }
    
    public class NewPersonFactory : PersonAbstractFactory
    {
        public override Villager GetVillager() => new Villager("New");

        public override Animal GetAnimal() => new Animal("New");
    }

}