using KPO_1.Animals;
using KPO_1.Things;

namespace KPO_1.Abstractions;

public interface IZooServices
{
    bool AcceptAnimals(Animal animal);
    void AddThing(Thing thing);

    int GetSumFood();
    List<Herbo> GetHerbivores();
    List<IInventory> GetInventories();
}