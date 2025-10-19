using KPO_1.Abstractions;
using Xunit;
using KPO_1.Animals;
using KPO_1.Services;

namespace TestProject1;

public class ServicesTests
{
    [Fact]
    public void AcceptAnimal()
    {
        var svc = new Zoo(new VeterinaryClinic(), new ZooRepository());
        bool flag = svc.AcceptAnimals(new Rabbit("Rabbit",1, 2, 8));
        Assert.True(flag);
    }

    [Fact]
    public void SumFood()
    {
        var svc = new Zoo(new VeterinaryClinic(), new ZooRepository());
        svc.AcceptAnimals(new Rabbit("Rabbit", 1, 2, 8));
        svc.AcceptAnimals(new Wolf("Wolf", 2, 3));
        int sum = svc.GetSumFood();
        Assert.Equal(5, sum);
    }
    

    [Fact]
    public void ContactZoo()
    {
        var svc = new Zoo(new VeterinaryClinic(), new ZooRepository());
        svc.AcceptAnimals(new Rabbit("Rabbit", 1, 1, 8));
        svc.AcceptAnimals(new Monkey("Monkey", 2, 3, 5));
        svc.AcceptAnimals(new Tiger("Tiger", 3, 3));
        var list = svc.GetHerbivores();
        Assert.Single(list);
        Assert.Equal(1, list[0].Number);
    }
}