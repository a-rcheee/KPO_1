using KPO_1.Animals;
using KPO_1.Services;
using KPO_1.Things;

namespace TestProject1;

public class ItemsTest
{
    [Fact]
    public void AddThing()
    {
        var rep = new ZooRepository();
        rep.AddThing(new Table("Table",31));
        var things = rep.GetThings();
        Assert.Single(things);
        Assert.Equal(31, things[0].Number);
    }

    [Fact]
    public void AddTwoThings()
    {
        var rep = new ZooRepository();
        rep.AddThing(new Computer("Computer",31));
        rep.AddThing(new Table("Table",39));
        var things = rep.GetThings();
        Assert.Equal(2, things.Count);
        Assert.Equal(31, things[0].Number);
        Assert.Equal(39, things[1].Number);
    }

    [Fact]
    public void GetThings()
    {
        var rep = new ZooRepository();
        rep.AddThing(new Table("Table",9));
        var a = rep.GetThings();
        var b = rep.GetThings();
        Assert.NotSame(a, b);
        Assert.Single(a);
        Assert.Single(b);
        Assert.Equal(9, a[0].Number);
        Assert.Equal(9, b[0].Number);
    }
    
    [Fact]
    public void AnimalNumber()
    {
        var svc = new Zoo(new VeterinaryClinic(), new ZooRepository());
        svc.AcceptAnimals(new Rabbit("Rabbit", 4, 3, 7));
        svc.AddThing(new Table("Table", 4));
        var items = svc.GetInventories();
        Assert.Equal(2, items.Count);
        Assert.Equal(4, items[0].Number);
        Assert.Equal(4, items[1].Number);
    }

    [Fact]
    public void EmpyRepository()
    {
        var rep = new ZooRepository();
        var things = rep.GetThings();
        Assert.Empty(things);
    }

    [Fact]
    public void InventoryMix()
    {
        var svc = new Zoo(new VeterinaryClinic(), new ZooRepository());
        svc.AcceptAnimals(new Rabbit("Rabbit", 4, 3, 7));
        svc.AddThing(new Table("Table", 6));
        var items = svc.GetInventories();
        Assert.Equal(2, items.Count);
        Assert.Equal(4, items[0].Number);
        Assert.Equal(6, items[1].Number); 
    }

    [Fact]
    public void SameNumber()
    {
        var svc = new Zoo(new VeterinaryClinic(), new ZooRepository());
        svc.AcceptAnimals(new Rabbit("Rabbit", 6, 3, 7));
        svc.AddThing(new Table("Table", 6));
        var items = svc.GetInventories();
        Assert.Equal(2, items.Count);
        Assert.Equal(6, items[0].Number);
        Assert.Equal(6, items[1].Number);
    }
}