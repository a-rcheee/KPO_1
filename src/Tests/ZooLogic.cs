using Xunit;
using KPO_1.Abstractions;
using KPO_1.Animals;
using KPO_1.Services;
using KPO_1.Things;

namespace TestProject1;

public class ZooLogic
{
    [Fact]
    public void HerbroFriendly()
    {
        var r1 = new Rabbit("Rabbit",1, 4, 5 );
        var r2 = new Rabbit("Rabbit",2, 3, 8 );
        Assert.False(r1.ContactZoo());
        Assert.True(r2.ContactZoo());
    }

    [Fact]
    public void Healthy()
    {
        IHealtCheck vet = new VeterinaryClinic();
        var unhealthy = new Wolf("Wolf", 8, 0);
        var healthy = new Wolf("Wolf", 10, 2);
        Assert.False(vet.CheckHealth(unhealthy));
        Assert.True(vet.CheckHealth(healthy));
    }

    [Fact]
    public void PredatorAccepted()
    {
        var svc = new Zoo(new VeterinaryClinic(), new ZooRepository());
        bool flag = svc.AcceptAnimals(new Wolf("Wolf", 8, 2));
        Assert.True(flag);
        var list = svc.GetHerbivores();
        Assert.Empty(list);
    }

    [Fact]
    public void Inventory()
    {
        var svc = new Zoo(new VeterinaryClinic(), new ZooRepository());
        svc.AddThing(new Table("Table", 100));
        svc.AddThing(new Computer("Computer", 200));
        var items = svc.GetInventories();
        Assert.Equal(2, items.Count);
    }

    [Fact]
    public void HerbivoreNotKindness()
    {
        var svc = new Zoo(new VeterinaryClinic(), new ZooRepository());
        bool flag = svc.AcceptAnimals(new Rabbit("Rabbit", 8, 2, 5));
        Assert.True(flag);
        var list = svc.GetHerbivores();
        Assert.Empty(list);
    }

    [Fact]
    public void ClinicApprove()
    {
        var zoo = new Zoo(new VeterinaryClinic(), new ZooRepository());
        var r = new Rabbit("Rabbit", 1, 2, 8);
        bool flag = zoo.AcceptAnimals(r);
        Assert.True(flag);
        var all = zoo.GetInventories();
        Assert.Single(all);
        var a0 = all[0] as Animal;
        Assert.NotNull(a0);
        Assert.Equal(1, a0.Number);
    }

    [Fact]
    public void FoodSum()
    {
        var zoo = new Zoo(new VeterinaryClinic(), new ZooRepository());
        zoo.AcceptAnimals(new Rabbit("Rabbit", 1, 2, 8));
        zoo.AcceptAnimals(new Wolf("Wolf", 8, 5));
        int sum = zoo.GetSumFood();
        Assert.Equal(7, sum);
    }

    [Fact]
    public void ContactZoo()
    {
        var zoo = new Zoo(new VeterinaryClinic(), new ZooRepository());
        var r3 = new Rabbit("Rabbit", 1, 4, 3);
        var r6 = new Rabbit("Rabbit", 2, 3, 6);
        var m8 = new Monkey("Monkey", 3, 2, 8);
        var t = new Tiger("Tiger", 4, 5);
        
        zoo.AcceptAnimals(r3);
        zoo.AcceptAnimals(r6);
        zoo.AcceptAnimals(m8);
        zoo.AcceptAnimals(t);
        var contact = zoo.GetHerbivores();
        Assert.Equal(2, contact.Count);
        Assert.True(contact[0].Kindness > 5);
        Assert.True(contact[1].Kindness > 5);
    }
}