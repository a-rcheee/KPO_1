using KPO_1.Abstractions;
using KPO_1.Animals;

namespace KPO_1.UI;

public class ChoiceAnimal
{
    public static void AddAnimal(IZooServices zoo)
    {
        Console.WriteLine(); 
        Console.WriteLine("Выбор животных:"); 
        Console.WriteLine("1) Monkey");
        Console.WriteLine("2) Rabbit");
        Console.WriteLine("3) Tiger");
        Console.WriteLine("4) Wolf");
        string? kind = Console.ReadLine();
        int number = Input.ReadInt("Инвентарный номер: ", InputField.InventoryNumber);
        int food = Input.ReadInt("Еда: ", InputField.Food);
        
        Animal? animal = null;
        if (kind == "1" || kind == "2")
        {
            int kindness = Input.ReadInt("Доброта: ", InputField.Kindness);
            if (kind == "1")
            {
                animal = new Monkey("Monkey", number, food, kindness);
            }
            else
            {
                animal = new Rabbit("Rabbit", number, food, kindness);
            }
        }

        else if (kind == "3")
        {
            animal = new Tiger("Tiger", number, food);
        }

        else if (kind == "4")
        {
            animal = new Wolf("Wolf", number, food);
        }
        else
        {
            Console.WriteLine("Мы не знаем такого животного");
        }
        bool accept = zoo.AcceptAnimals(animal);
        if (accept)
        {
            Console.WriteLine("Животное теперь в зоопарке");
        }
        else
        {
            Console.WriteLine("Животное не подошло для зоопарка");
        }
    }
}