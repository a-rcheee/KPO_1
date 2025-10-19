using KPO_1.Abstractions;

namespace KPO_1.Animals;

public abstract class Animal : IAlive, IInventory
{
    public string Name { get; }
    public int Number { get; }
    public int Food {get; }

    protected Animal(string name, int number, int food)
    {
        Name = name;
        Number = number;
        Food = food;
    }
}