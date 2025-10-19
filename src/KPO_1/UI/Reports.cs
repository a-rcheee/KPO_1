using KPO_1.Abstractions;
using KPO_1.Animals;
using KPO_1.Things;

namespace KPO_1.UI;

public class Reports
{
    public static void ShowSumFood(IZooServices zoo)
    {
        Console.WriteLine();
        int sum = zoo.GetSumFood();
        Console.WriteLine($"Сумма нужно кол-ва корма в сутки: {sum} кг");
    }

    public static void ShowContactZoo(IZooServices zoo)
    {
        Console.WriteLine();
        var list = zoo.GetHerbivores();
        if (list.Count == 0)
        {
            Console.WriteLine("Животных нет :(");
            return;
        }
        Console.WriteLine("Животные из контактного зоопарка:");
        foreach (var animal in list)
        {
            Console.WriteLine($"{animal.Name}, инвентарный номер - {animal.Number}, уровень доброты - {animal.Kindness}");
        }
    }

    public static void ShowInventory(IZooServices zoo)
    {
        Console.WriteLine();
        var items = zoo.GetInventories();
        if (items.Count == 0)
        {
            Console.WriteLine("Ничего не найдено");
            return;
        }
        
        Console.WriteLine("Инвентарные животные и вещи:");
        foreach (var item in items)
        {
            string name;
            if (item is Animal animal)
            {
                name = animal.Name;
            }

            else if (item is Thing thing)
            {
                name = thing.Name;
            }
            else
            {
                name = "item";
            }
            Console.WriteLine($"{name} - инветнарый номер - {item.Number}");
        }
    }
}