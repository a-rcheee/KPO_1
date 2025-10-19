using KPO_1.Abstractions;
using KPO_1.Things;

namespace KPO_1.UI;

public class ChoiceThing
{
    public static void AddThing(IZooServices zoo)
    {
        Console.WriteLine();
        Console.WriteLine("Вещи:");
        Console.WriteLine("1) Table");
        Console.WriteLine("2) Computer");
        Console.Write("Выберите вещь: ");
        string? kind = Console.ReadLine();
        int number = Input.ReadInt("Инвентарный номер: ", InputField.InventoryNumber);
        Thing? thing = null;
        if (kind == "1")
        {
            thing = new Table("Table", number);
        }

        else if (kind == "2")
        {
            thing = new Computer("Computer", number);
        }
        else
        {
            Console.WriteLine("Такой вещи не знаем");
            return;
        }
        zoo.AddThing(thing);
        Console.WriteLine("Вещь добавлена");
    }
}