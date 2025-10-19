using KPO_1.Abstractions;
using KPO_1.Animals;
using KPO_1.Things;

namespace KPO_1.Services;

public class Zoo : IZooServices
{
    private readonly IZooRepository _zooRepository;
    private readonly IHealtCheck _healtCheck;

    public Zoo(IHealtCheck healtCheck, IZooRepository zooRepository)
    {
        _healtCheck = healtCheck;
        _zooRepository = zooRepository;
    }

    public bool AcceptAnimals(Animal animal)
    {
        if (!_healtCheck.CheckHealth(animal))
        {
            return false;
        }
        _zooRepository.AddAnimal(animal);
        return true;
    }

    public void AddThing(Thing thing)
    {
        _zooRepository.AddThing(thing);
    }

    public int GetSumFood()
    {
        int sum = 0;
        List<Animal> animals = _zooRepository.GetAnimals();

        foreach (Animal animal in animals)
        {
            sum += animal.Food;
        }
        
        return sum;
    }

    public List<Herbo> GetHerbivores()
    {
        var animals = _zooRepository.GetAnimals();
        var result = new List<Herbo>();

        foreach (Animal animal in animals)
        {
            if (animal is Herbo herbo && herbo.ContactZoo())
            {
                result.Add(herbo);
            }
        }
        return result;
    }

    public List<IInventory> GetInventories()
    {
        var result = new List<IInventory>();
        foreach (var a in _zooRepository.GetAnimals())
        {
            result.Add(a);
        }

        foreach (var b in _zooRepository.GetThings())
        {
            result.Add(b);
        }
        return result;
    }
    
}