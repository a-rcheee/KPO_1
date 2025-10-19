using KPO_1.Abstractions;

namespace KPO_1.Things;

public class Thing : IInventory
{
    public string Name { get; }
    public int Number { get; }

    public Thing(string name, int number)
    {
        Name = name;
        Number = number;
    }
}