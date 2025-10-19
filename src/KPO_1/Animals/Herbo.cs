namespace KPO_1.Animals;

public abstract class Herbo : Animal
{
    public int Kindness { get; }
    
    public bool ContactZoo() => Kindness > 5;

    protected Herbo(string name, int number, int food, int kindness) : base(name, number, food)
    {
        Kindness = kindness;
    }
}