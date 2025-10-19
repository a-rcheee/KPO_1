using KPO_1.Animals;
using KPO_1.Things;

namespace KPO_1.Abstractions;

public interface IZooRepository
{
    void AddAnimal(Animal animal);
    void AddThing(Thing thing);
    
    List<Animal> GetAnimals();
    List<Thing> GetThings();
}