using KPO_1.Abstractions;
using KPO_1.Animals;

namespace KPO_1.Services;

public class VeterinaryClinic : IHealtCheck
{
    // Если может кушать, то здоров
    public bool CheckHealth(Animal animal) => animal.Food > 0;
}