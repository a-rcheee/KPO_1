using KPO_1.Abstractions;
using KPO_1.Animals;
using KPO_1.Things;

namespace KPO_1.Services;

public class ZooRepository : IZooRepository
{
   private readonly List<Animal> _animals = new();
   private readonly List<Thing> _things = new();

   public void AddAnimal(Animal animal)
   {
      _animals.Add(animal);
   }
   public void AddThing(Thing thing)
   {
      _things.Add(thing);
   }
   public List<Animal> GetAnimals()
   {
      var animal = new List<Animal>();
      foreach (var a in _animals)
      {
         animal.Add(a);
      }
      return animal;
   }

   public List<Thing> GetThings()
   {
      var thing = new List<Thing>();
      foreach (var t in _things)
      {
         thing.Add(t);
      }

      return thing;
   }
}